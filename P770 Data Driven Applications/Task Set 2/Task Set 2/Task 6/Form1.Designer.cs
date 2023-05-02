namespace Task_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSalary2 = new System.Windows.Forms.TextBox();
            this.txtPostcode2 = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.lblSalary2 = new System.Windows.Forms.Label();
            this.lblPostcode2 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeID2 = new System.Windows.Forms.TextBox();
            this.txtStartDate2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 140);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(198, 83);
            this.txtAddress.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "First Name:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(43, 98);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(40, 143);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(40, 249);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(55, 13);
            this.postcodeLabel.TabIndex = 8;
            this.postcodeLabel.Text = "Postcode:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(40, 291);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Text = "Salary:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(43, 334);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Start Date:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(43, 374);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "EmployeeID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(229, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(198, 20);
            this.txtFirstName.TabIndex = 17;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(106, 98);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(198, 20);
            this.txtSurname.TabIndex = 18;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(106, 249);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(198, 20);
            this.txtPostcode.TabIndex = 19;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(106, 291);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(198, 20);
            this.txtSalary.TabIndex = 20;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(106, 334);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(198, 20);
            this.txtStartDate.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(229, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(106, 23);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(47, 20);
            this.txtEmployeeID.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(46, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSalary2
            // 
            this.txtSalary2.Location = new System.Drawing.Point(484, 291);
            this.txtSalary2.Name = "txtSalary2";
            this.txtSalary2.Size = new System.Drawing.Size(198, 20);
            this.txtSalary2.TabIndex = 30;
            // 
            // txtPostcode2
            // 
            this.txtPostcode2.Location = new System.Drawing.Point(484, 249);
            this.txtPostcode2.Name = "txtPostcode2";
            this.txtPostcode2.Size = new System.Drawing.Size(198, 20);
            this.txtPostcode2.TabIndex = 29;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(484, 98);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(198, 20);
            this.txtSurname2.TabIndex = 28;
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Location = new System.Drawing.Point(484, 54);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(198, 20);
            this.txtFirstName2.TabIndex = 27;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(484, 143);
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(198, 83);
            this.txtAddress2.TabIndex = 26;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Enabled = false;
            this.btnUpdate2.Location = new System.Drawing.Point(548, 394);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate2.TabIndex = 32;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            this.btnUpdate2.Click += new System.EventHandler(this.BtnUpdate2_Click);
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.Location = new System.Drawing.Point(404, 57);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName2.TabIndex = 33;
            this.lblFirstName2.Text = "First Name:";
            // 
            // lblSalary2
            // 
            this.lblSalary2.AutoSize = true;
            this.lblSalary2.Location = new System.Drawing.Point(401, 291);
            this.lblSalary2.Name = "lblSalary2";
            this.lblSalary2.Size = new System.Drawing.Size(39, 13);
            this.lblSalary2.TabIndex = 37;
            this.lblSalary2.Text = "Salary:";
            // 
            // lblPostcode2
            // 
            this.lblPostcode2.AutoSize = true;
            this.lblPostcode2.Location = new System.Drawing.Point(401, 249);
            this.lblPostcode2.Name = "lblPostcode2";
            this.lblPostcode2.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode2.TabIndex = 36;
            this.lblPostcode2.Text = "Postcode:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(404, 143);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(48, 13);
            this.lblAddress2.TabIndex = 35;
            this.lblAddress2.Text = "Address:";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(404, 98);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(52, 13);
            this.lblSurname2.TabIndex = 34;
            this.lblSurname2.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "EmployeeID";
            // 
            // txtEmployeeID2
            // 
            this.txtEmployeeID2.Location = new System.Drawing.Point(484, 23);
            this.txtEmployeeID2.Name = "txtEmployeeID2";
            this.txtEmployeeID2.ReadOnly = true;
            this.txtEmployeeID2.Size = new System.Drawing.Size(47, 20);
            this.txtEmployeeID2.TabIndex = 40;
            // 
            // txtStartDate2
            // 
            this.txtStartDate2.Location = new System.Drawing.Point(484, 334);
            this.txtStartDate2.Name = "txtStartDate2";
            this.txtStartDate2.Size = new System.Drawing.Size(198, 20);
            this.txtStartDate2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Start Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartDate2);
            this.Controls.Add(this.txtEmployeeID2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSalary2);
            this.Controls.Add(this.lblPostcode2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblSurname2);
            this.Controls.Add(this.lblFirstName2);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.txtSalary2);
            this.Controls.Add(this.txtPostcode2);
            this.Controls.Add(this.txtSurname2);
            this.Controls.Add(this.txtFirstName2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.txtAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label surnameLabel;
        public System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.Label postcodeLabel;
        public System.Windows.Forms.Label salaryLabel;
        public System.Windows.Forms.Label startDateLabel;
        public System.Windows.Forms.Button createButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtPostcode;
        public System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.TextBox txtStartDate;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtEmployeeID;
        public System.Windows.Forms.Button btnDelete;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSalary2;
        public System.Windows.Forms.TextBox txtPostcode2;
        public System.Windows.Forms.TextBox txtSurname2;
        public System.Windows.Forms.TextBox txtFirstName2;
        public System.Windows.Forms.TextBox txtAddress2;
        public System.Windows.Forms.Button btnUpdate2;
        public System.Windows.Forms.Label lblFirstName2;
        public System.Windows.Forms.Label lblSalary2;
        public System.Windows.Forms.Label lblPostcode2;
        public System.Windows.Forms.Label lblAddress2;
        public System.Windows.Forms.Label lblSurname2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmployeeID2;
        public System.Windows.Forms.TextBox txtStartDate2;
        public System.Windows.Forms.Label label3;
    }
}

