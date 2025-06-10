using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Week_10_Assignment_10._1
{

    public class ConstructionWorker
    {     
        public string ConstructionWorkerFirstName {get; set;}
      
        public string ConstructionWorkerLastName { get; set; }
       
        public string ConstructionWorkerAddress { get; set; }

        public long ConstructionWorkerPhoneNumber { get; set; }
    }
}
