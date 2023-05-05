namespace Presentation_Tier
{
    partial class OwnerDetailsPage
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
            this.components = new System.ComponentModel.Container();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOwnerSurname = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblOwnerFirst = new System.Windows.Forms.Label();
            this.lblOwnerDetails = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnHideCars = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAstericks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPresentationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Enabled = false;
            this.btnSelectAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAddress.Location = new System.Drawing.Point(657, 101);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(107, 26);
            this.btnSelectAddress.TabIndex = 64;
            this.btnSelectAddress.Text = "Select Address";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.SelectAddressClick);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(226, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 37);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(476, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 37);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.OwnerID,
            this.regNumberDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.makeNameDataGridViewTextBoxColumn,
            this.colourNameDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.OwnerFirstName,
            this.OwnerSurname});
            this.dgvCars.DataSource = this.carPresentationBindingSource;
            this.dgvCars.Location = new System.Drawing.Point(126, 320);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(544, 344);
            this.dgvCars.TabIndex = 60;
            this.dgvCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGridClick);
            // 
            // OwnerID
            // 
            this.OwnerID.DataPropertyName = "OwnerID";
            this.OwnerID.HeaderText = "OwnerID";
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.ReadOnly = true;
            this.OwnerID.Visible = false;
            // 
            // OwnerFirstName
            // 
            this.OwnerFirstName.DataPropertyName = "OwnerFirstName";
            this.OwnerFirstName.HeaderText = "OwnerFirstName";
            this.OwnerFirstName.Name = "OwnerFirstName";
            this.OwnerFirstName.ReadOnly = true;
            this.OwnerFirstName.Visible = false;
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.DataPropertyName = "OwnerSurname";
            this.OwnerSurname.HeaderText = "OwnerSurname";
            this.OwnerSurname.Name = "OwnerSurname";
            this.OwnerSurname.ReadOnly = true;
            this.OwnerSurname.Visible = false;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(382, 144);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(112, 20);
            this.lblDOB.TabIndex = 56;
            this.lblDOB.Text = "Date Of Birth *";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(382, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Address *";
            // 
            // lblOwnerSurname
            // 
            this.lblOwnerSurname.AutoSize = true;
            this.lblOwnerSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerSurname.Location = new System.Drawing.Point(32, 141);
            this.lblOwnerSurname.Name = "lblOwnerSurname";
            this.lblOwnerSurname.Size = new System.Drawing.Size(84, 20);
            this.lblOwnerSurname.TabIndex = 51;
            this.lblOwnerSurname.Text = "Surname *";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(355, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 37);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.EditClick);
            // 
            // lblOwnerFirst
            // 
            this.lblOwnerFirst.AutoSize = true;
            this.lblOwnerFirst.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerFirst.Location = new System.Drawing.Point(32, 102);
            this.lblOwnerFirst.Name = "lblOwnerFirst";
            this.lblOwnerFirst.Size = new System.Drawing.Size(96, 20);
            this.lblOwnerFirst.TabIndex = 49;
            this.lblOwnerFirst.Text = "First Name *";
            // 
            // lblOwnerDetails
            // 
            this.lblOwnerDetails.AutoSize = true;
            this.lblOwnerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerDetails.Location = new System.Drawing.Point(234, 18);
            this.lblOwnerDetails.Name = "lblOwnerDetails";
            this.lblOwnerDetails.Size = new System.Drawing.Size(338, 55);
            this.lblOwnerDetails.TabIndex = 48;
            this.lblOwnerDetails.Text = "Owner Details";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(162, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 47;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(25, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(162, 143);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 65;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(495, 144);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(156, 20);
            this.dtpDOB.TabIndex = 66;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(495, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(156, 20);
            this.txtAddress.TabIndex = 67;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(126, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.AddClick);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(576, 207);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(94, 37);
            this.btnCancelAdd.TabIndex = 69;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Visible = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.CancelAddClick);
            // 
            // btnShowCars
            // 
            this.btnShowCars.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnShowCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCars.Location = new System.Drawing.Point(341, 670);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(109, 37);
            this.btnShowCars.TabIndex = 70;
            this.btnShowCars.Text = "Show Cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.ShowCarsClick);
            // 
            // btnHideCars
            // 
            this.btnHideCars.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnHideCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideCars.Location = new System.Drawing.Point(341, 670);
            this.btnHideCars.Name = "btnHideCars";
            this.btnHideCars.Size = new System.Drawing.Size(109, 37);
            this.btnHideCars.TabIndex = 71;
            this.btnHideCars.Text = "Hide Cars";
            this.btnHideCars.UseVisualStyleBackColor = true;
            this.btnHideCars.Visible = false;
            this.btnHideCars.Click += new System.EventHandler(this.HideCarsClick);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(576, 277);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(94, 37);
            this.btnAddCar.TabIndex = 72;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Visible = false;
            this.btnAddCar.Click += new System.EventHandler(this.AddCarClick);
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // regNumberDataGridViewTextBoxColumn
            // 
            this.regNumberDataGridViewTextBoxColumn.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.regNumberDataGridViewTextBoxColumn.Name = "regNumberDataGridViewTextBoxColumn";
            this.regNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            this.modelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeNameDataGridViewTextBoxColumn
            // 
            this.makeNameDataGridViewTextBoxColumn.DataPropertyName = "MakeName";
            this.makeNameDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeNameDataGridViewTextBoxColumn.Name = "makeNameDataGridViewTextBoxColumn";
            this.makeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colourNameDataGridViewTextBoxColumn
            // 
            this.colourNameDataGridViewTextBoxColumn.DataPropertyName = "ColourName";
            this.colourNameDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourNameDataGridViewTextBoxColumn.Name = "colourNameDataGridViewTextBoxColumn";
            this.colourNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "Registration Date";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carPresentationBindingSource
            // 
            this.carPresentationBindingSource.DataSource = typeof(Model_Library.CarPresentation);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(33, 75);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(185, 13);
            this.lblAstericks.TabIndex = 79;
            this.lblAstericks.Text = "All Required Fields Marked by *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Click on a row in the grid to view details";
            // 
            // OwnerDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnHideCars);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblOwnerSurname);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblOwnerFirst);
            this.Controls.Add(this.lblOwnerDetails);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClose);
            this.Name = "OwnerDetailsPage";
            this.Text = "Owner Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPresentationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSelectAddress;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOwnerSurname;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblOwnerFirst;
        private System.Windows.Forms.Label lblOwnerDetails;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.BindingSource carPresentationBindingSource;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnCancelAdd;
        public System.Windows.Forms.Button btnShowCars;
        public System.Windows.Forms.Button btnHideCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerSurname;
        public System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblAstericks;
        private System.Windows.Forms.Label label1;
    }
}
