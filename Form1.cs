using System.Xml.Serialization;
using System.Text.Json;


namespace Week_10_Assignment_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConstructionWorker worker;
        private string jsonpath = @"C:\assignment10json.txt";
        private string xmlpath = @"C:\assignment10xml.xml";
        private void buttonCW_Click(object sender, EventArgs e)
        {
            worker = new ConstructionWorker();
            worker.ConstructionWorkerFirstName = textFirstName.Text;
            worker.ConstructionWorkerLastName = textLastName.Text;
            worker.ConstructionWorkerAddress = textAddress.Text;
            worker.ConstructionWorkerPhoneNumber = Convert.ToInt64(textPhoneNumber.Text);

            MessageBox.Show("Construction Worker Created");
            
        }

        private void buttonXmlSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }
            FileStream xmlfilestream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(ConstructionWorker));
            xmlserializer.Serialize(xmlfilestream, worker);
            xmlfilestream.Close();
            MessageBox.Show("Construction worker to XML file" + xmlpath);

        }

        private void buttonXmlDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream xmlfilestream = new FileStream(xmlpath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(ConstructionWorker));
            var obj = xmlserializer.Deserialize(xmlfilestream) as ConstructionWorker;
            MessageBox.Show($"Construction Worker First name: {obj.ConstructionWorkerFirstName}, " +
                            $"Construction Worker Last name: {obj.ConstructionWorkerLastName}, " +
                            $"Construction Worker Address: {obj.ConstructionWorkerAddress}, " +
            $"Construction Worker Phone Number: {obj.ConstructionWorkerPhoneNumber}");
        }

        private void buttonJsonSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonpath))
            {
                File.Delete(jsonpath);
            }
            FileStream jsonfilestream = new FileStream(jsonpath, FileMode.OpenOrCreate, FileAccess.Write);
            
                JsonSerializer.Serialize(jsonfilestream, worker);
                jsonfilestream.Close();
                MessageBox.Show("Construction worker Serialized to JSON file: " + jsonpath);
            }
        
        private void buttonJsonDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream jsonfilestream = new FileStream(jsonpath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<ConstructionWorker>(jsonfilestream);
            MessageBox.Show($"Construction Worker First name: {obj.ConstructionWorkerFirstName}, " +
                            $"Construction Worker Last name: {obj.ConstructionWorkerLastName}, " +
                            $"Construction Worker Address: {obj.ConstructionWorkerAddress}, " +
            $"Construction Worker Phone Number: {obj.ConstructionWorkerPhoneNumber}");
        }
    }
}
