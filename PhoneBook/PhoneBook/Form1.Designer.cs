namespace PhoneBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.buttonAddToPhoneBook = new System.Windows.Forms.Button();
            this.comboBoxChooserPerson = new System.Windows.Forms.ComboBox();
            this.labelAddPhoneBook = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.labelChooseFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(13, 40);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(13, 67);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(13, 94);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelephoneNumber.TabIndex = 2;
            // 
            // buttonAddToPhoneBook
            // 
            this.buttonAddToPhoneBook.Location = new System.Drawing.Point(13, 121);
            this.buttonAddToPhoneBook.Name = "buttonAddToPhoneBook";
            this.buttonAddToPhoneBook.Size = new System.Drawing.Size(100, 23);
            this.buttonAddToPhoneBook.TabIndex = 3;
            this.buttonAddToPhoneBook.Text = "button1";
            this.buttonAddToPhoneBook.UseVisualStyleBackColor = true;
            this.buttonAddToPhoneBook.Click += new System.EventHandler(this.buttonAddToPhoneBook_Click);
            // 
            // comboBoxChooserPerson
            // 
            this.comboBoxChooserPerson.FormattingEnabled = true;
            this.comboBoxChooserPerson.Location = new System.Drawing.Point(12, 178);
            this.comboBoxChooserPerson.Name = "comboBoxChooserPerson";
            this.comboBoxChooserPerson.Size = new System.Drawing.Size(259, 21);
            this.comboBoxChooserPerson.TabIndex = 4;
            this.comboBoxChooserPerson.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooserPerson_SelectedIndexChanged);
            // 
            // labelAddPhoneBook
            // 
            this.labelAddPhoneBook.AutoSize = true;
            this.labelAddPhoneBook.Location = new System.Drawing.Point(13, 13);
            this.labelAddPhoneBook.Name = "labelAddPhoneBook";
            this.labelAddPhoneBook.Size = new System.Drawing.Size(35, 13);
            this.labelAddPhoneBook.TabIndex = 5;
            this.labelAddPhoneBook.Text = "label1";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(120, 46);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "label2";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(120, 73);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(35, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "label3";
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(120, 100);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(35, 13);
            this.labelTelephoneNumber.TabIndex = 8;
            this.labelTelephoneNumber.Text = "label4";
            // 
            // labelChooseFullName
            // 
            this.labelChooseFullName.AutoSize = true;
            this.labelChooseFullName.Location = new System.Drawing.Point(13, 162);
            this.labelChooseFullName.Name = "labelChooseFullName";
            this.labelChooseFullName.Size = new System.Drawing.Size(35, 13);
            this.labelChooseFullName.TabIndex = 9;
            this.labelChooseFullName.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelChooseFullName);
            this.Controls.Add(this.labelTelephoneNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelAddPhoneBook);
            this.Controls.Add(this.comboBoxChooserPerson);
            this.Controls.Add(this.buttonAddToPhoneBook);
            this.Controls.Add(this.textBoxTelephoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.Button buttonAddToPhoneBook;
        private System.Windows.Forms.ComboBox comboBoxChooserPerson;
        private System.Windows.Forms.Label labelAddPhoneBook;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.Label labelChooseFullName;
    }
}

