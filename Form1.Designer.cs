namespace Week_10_Assignment_10._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            textFirstName = new TextBox();
            textLastName = new TextBox();
            textAddress = new TextBox();
            textPhoneNumber = new TextBox();
            buttonCW = new Button();
            buttonXmlSerialize = new Button();
            buttonJsonSerialize = new Button();
            buttonXmlDeSerialize = new Button();
            buttonJsonDeSerialize = new Button();
            lbxlm = new Label();
            lbjson = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(85, 64);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(85, 113);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(85, 159);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(85, 214);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(187, 64);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(173, 23);
            textFirstName.TabIndex = 4;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(187, 113);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(173, 23);
            textLastName.TabIndex = 5;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(187, 159);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(173, 23);
            textAddress.TabIndex = 6;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(187, 214);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(173, 23);
            textPhoneNumber.TabIndex = 7;
            // 
            // buttonCW
            // 
            buttonCW.Location = new Point(126, 285);
            buttonCW.Name = "buttonCW";
            buttonCW.Size = new Size(202, 23);
            buttonCW.TabIndex = 8;
            buttonCW.Text = "Create Construction Worker";
            buttonCW.UseVisualStyleBackColor = true;
            buttonCW.Click += buttonCW_Click;
            // 
            // buttonXmlSerialize
            // 
            buttonXmlSerialize.Location = new Point(558, 68);
            buttonXmlSerialize.Name = "buttonXmlSerialize";
            buttonXmlSerialize.Size = new Size(159, 23);
            buttonXmlSerialize.TabIndex = 9;
            buttonXmlSerialize.Text = "XLM Serialize";
            buttonXmlSerialize.UseVisualStyleBackColor = true;
            buttonXmlSerialize.Click += buttonXmlSerialize_Click;
            // 
            // buttonJsonSerialize
            // 
            buttonJsonSerialize.Location = new Point(558, 133);
            buttonJsonSerialize.Name = "buttonJsonSerialize";
            buttonJsonSerialize.Size = new Size(159, 23);
            buttonJsonSerialize.TabIndex = 10;
            buttonJsonSerialize.Text = "JSON Serialize";
            buttonJsonSerialize.UseVisualStyleBackColor = true;
            buttonJsonSerialize.Click += buttonJsonSerialize_Click;
            // 
            // buttonXmlDeSerialize
            // 
            buttonXmlDeSerialize.Location = new Point(760, 68);
            buttonXmlDeSerialize.Name = "buttonXmlDeSerialize";
            buttonXmlDeSerialize.Size = new Size(152, 23);
            buttonXmlDeSerialize.TabIndex = 11;
            buttonXmlDeSerialize.Text = "XML DeSerialize";
            buttonXmlDeSerialize.UseVisualStyleBackColor = true;
            buttonXmlDeSerialize.Click += buttonXmlDeSerialize_Click;
            // 
            // buttonJsonDeSerialize
            // 
            buttonJsonDeSerialize.Location = new Point(760, 133);
            buttonJsonDeSerialize.Name = "buttonJsonDeSerialize";
            buttonJsonDeSerialize.Size = new Size(152, 23);
            buttonJsonDeSerialize.TabIndex = 12;
            buttonJsonDeSerialize.Text = "JSON DeSerialize";
            buttonJsonDeSerialize.UseVisualStyleBackColor = true;
            buttonJsonDeSerialize.Click += buttonJsonDeSerialize_Click;
            // 
            // lbxlm
            // 
            lbxlm.AutoSize = true;
            lbxlm.Location = new Point(501, 72);
            lbxlm.Name = "lbxlm";
            lbxlm.Size = new Size(34, 15);
            lbxlm.TabIndex = 13;
            lbxlm.Text = "XLM:";
            // 
            // lbjson
            // 
            lbjson.AutoSize = true;
            lbjson.Location = new Point(501, 137);
            lbjson.Name = "lbjson";
            lbjson.Size = new Size(41, 15);
            lbjson.TabIndex = 14;
            lbjson.Text = "JSON: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 534);
            Controls.Add(lbjson);
            Controls.Add(lbxlm);
            Controls.Add(buttonJsonDeSerialize);
            Controls.Add(buttonXmlDeSerialize);
            Controls.Add(buttonJsonSerialize);
            Controls.Add(buttonXmlSerialize);
            Controls.Add(buttonCW);
            Controls.Add(textPhoneNumber);
            Controls.Add(textAddress);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private TextBox textFirstName;
        private TextBox textLastName;
        private TextBox textAddress;
        private TextBox textPhoneNumber;
        private Button buttonCW;
        private Button buttonXmlSerialize;
        private Button buttonJsonSerialize;
        private Button buttonXmlDeSerialize;
        private Button buttonJsonDeSerialize;
        private Label lbxlm;
        private Label lbjson;
    }
}
