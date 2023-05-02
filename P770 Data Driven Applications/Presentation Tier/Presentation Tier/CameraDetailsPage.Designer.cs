namespace Presentation_Tier
{
    partial class CameraDetailsPage
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
            this.dgvSightings = new System.Windows.Forms.DataGridView();
            this.CameraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sightingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondsAfterRedLightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sightingCarPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblRoadNumber = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRoadName = new System.Windows.Forms.Label();
            this.lblCameraDetails = new System.Windows.Forms.Label();
            this.txtRoadName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRoadNumber = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblCameraType = new System.Windows.Forms.Label();
            this.cmbCameraType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpeedThreshold = new System.Windows.Forms.TextBox();
            this.txtTimeThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowSightings = new System.Windows.Forms.Button();
            this.btnHideSightings = new System.Windows.Forms.Button();
            this.cameraPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightingPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAstericks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSightings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingCarPresentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPresentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingPresentationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Enabled = false;
            this.btnSelectAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAddress.Location = new System.Drawing.Point(368, 185);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(108, 30);
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
            this.btnSave.Location = new System.Drawing.Point(268, 261);
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
            this.btnCancel.Location = new System.Drawing.Point(506, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 37);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // dgvSightings
            // 
            this.dgvSightings.AllowUserToAddRows = false;
            this.dgvSightings.AllowUserToDeleteRows = false;
            this.dgvSightings.AutoGenerateColumns = false;
            this.dgvSightings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSightings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CameraID,
            this.RegNumber,
            this.sightingTimeDataGridViewTextBoxColumn,
            this.secondsAfterRedLightDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.datePaidDataGridViewTextBoxColumn});
            this.dgvSightings.DataSource = this.sightingCarPresentationBindingSource;
            this.dgvSightings.Location = new System.Drawing.Point(34, 312);
            this.dgvSightings.Name = "dgvSightings";
            this.dgvSightings.ReadOnly = true;
            this.dgvSightings.Size = new System.Drawing.Size(792, 344);
            this.dgvSightings.TabIndex = 60;
            // 
            // CameraID
            // 
            this.CameraID.DataPropertyName = "CameraID";
            this.CameraID.HeaderText = "CameraID";
            this.CameraID.Name = "CameraID";
            this.CameraID.ReadOnly = true;
            this.CameraID.Visible = false;
            // 
            // RegNumber
            // 
            this.RegNumber.DataPropertyName = "RegNumber";
            this.RegNumber.HeaderText = "RegNumber";
            this.RegNumber.Name = "RegNumber";
            this.RegNumber.ReadOnly = true;
            // 
            // sightingTimeDataGridViewTextBoxColumn
            // 
            this.sightingTimeDataGridViewTextBoxColumn.DataPropertyName = "SightingTime";
            this.sightingTimeDataGridViewTextBoxColumn.HeaderText = "SightingTime";
            this.sightingTimeDataGridViewTextBoxColumn.Name = "sightingTimeDataGridViewTextBoxColumn";
            this.sightingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondsAfterRedLightDataGridViewTextBoxColumn
            // 
            this.secondsAfterRedLightDataGridViewTextBoxColumn.DataPropertyName = "SecondsAfterRedLight";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.HeaderText = "SecondsAfterRedLight";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.Name = "secondsAfterRedLightDataGridViewTextBoxColumn";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "Fine Date Issued";
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePaidDataGridViewTextBoxColumn
            // 
            this.datePaidDataGridViewTextBoxColumn.DataPropertyName = "DatePaid";
            this.datePaidDataGridViewTextBoxColumn.HeaderText = "Fine Date Paid";
            this.datePaidDataGridViewTextBoxColumn.Name = "datePaidDataGridViewTextBoxColumn";
            this.datePaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sightingCarPresentationBindingSource
            // 
            this.sightingCarPresentationBindingSource.DataSource = typeof(Model_Library.SightingCarPresentation);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 187);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 56;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(206, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(156, 20);
            this.txtAddress.TabIndex = 55;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(502, 148);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(77, 20);
            this.lblLatitude.TabIndex = 53;
            this.lblLatitude.Text = "Latitude *";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(502, 107);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(90, 20);
            this.lblLongitude.TabIndex = 52;
            this.lblLongitude.Text = "Longitude *";
            // 
            // lblRoadNumber
            // 
            this.lblRoadNumber.AutoSize = true;
            this.lblRoadNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadNumber.Location = new System.Drawing.Point(30, 146);
            this.lblRoadNumber.Name = "lblRoadNumber";
            this.lblRoadNumber.Size = new System.Drawing.Size(108, 20);
            this.lblRoadNumber.TabIndex = 51;
            this.lblRoadNumber.Text = "Road Number";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(390, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 37);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.EditClick);
            // 
            // lblRoadName
            // 
            this.lblRoadName.AutoSize = true;
            this.lblRoadName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadName.Location = new System.Drawing.Point(30, 107);
            this.lblRoadName.Name = "lblRoadName";
            this.lblRoadName.Size = new System.Drawing.Size(104, 20);
            this.lblRoadName.TabIndex = 49;
            this.lblRoadName.Text = "Road Name *";
            // 
            // lblCameraDetails
            // 
            this.lblCameraDetails.AutoSize = true;
            this.lblCameraDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraDetails.Location = new System.Drawing.Point(268, 24);
            this.lblCameraDetails.Name = "lblCameraDetails";
            this.lblCameraDetails.Size = new System.Drawing.Size(369, 55);
            this.lblCameraDetails.TabIndex = 48;
            this.lblCameraDetails.Text = "Camera Details";
            // 
            // txtRoadName
            // 
            this.txtRoadName.Enabled = false;
            this.txtRoadName.Location = new System.Drawing.Point(206, 109);
            this.txtRoadName.Name = "txtRoadName";
            this.txtRoadName.Size = new System.Drawing.Size(156, 20);
            this.txtRoadName.TabIndex = 47;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(31, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // txtRoadNumber
            // 
            this.txtRoadNumber.Enabled = false;
            this.txtRoadNumber.Location = new System.Drawing.Point(206, 148);
            this.txtRoadNumber.Name = "txtRoadNumber";
            this.txtRoadNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRoadNumber.TabIndex = 65;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(675, 107);
            this.txtLongitude.MaxLength = 8;
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(156, 20);
            this.txtLongitude.TabIndex = 66;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(675, 147);
            this.txtLatitude.MaxLength = 8;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(156, 20);
            this.txtLatitude.TabIndex = 67;
            // 
            // lblCameraType
            // 
            this.lblCameraType.AutoSize = true;
            this.lblCameraType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCameraType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraType.Location = new System.Drawing.Point(502, 189);
            this.lblCameraType.Name = "lblCameraType";
            this.lblCameraType.Size = new System.Drawing.Size(113, 20);
            this.lblCameraType.TabIndex = 68;
            this.lblCameraType.Text = "Camera Type *";
            // 
            // cmbCameraType
            // 
            this.cmbCameraType.Enabled = false;
            this.cmbCameraType.FormattingEnabled = true;
            this.cmbCameraType.Location = new System.Drawing.Point(675, 187);
            this.cmbCameraType.Name = "cmbCameraType";
            this.cmbCameraType.Size = new System.Drawing.Size(156, 21);
            this.cmbCameraType.TabIndex = 69;
            this.cmbCameraType.SelectedValueChanged += new System.EventHandler(this.CameraTypeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Speed Threshold * (mph)";
            // 
            // txtSpeedThreshold
            // 
            this.txtSpeedThreshold.Enabled = false;
            this.txtSpeedThreshold.Location = new System.Drawing.Point(222, 229);
            this.txtSpeedThreshold.Name = "txtSpeedThreshold";
            this.txtSpeedThreshold.Size = new System.Drawing.Size(140, 20);
            this.txtSpeedThreshold.TabIndex = 71;
            // 
            // txtTimeThreshold
            // 
            this.txtTimeThreshold.Enabled = false;
            this.txtTimeThreshold.Location = new System.Drawing.Point(675, 231);
            this.txtTimeThreshold.Name = "txtTimeThreshold";
            this.txtTimeThreshold.Size = new System.Drawing.Size(156, 20);
            this.txtTimeThreshold.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Time Threshold * (s)";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(150, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.AddClick);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(627, 261);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 37);
            this.btnClear.TabIndex = 75;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // btnShowSightings
            // 
            this.btnShowSightings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSightings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSightings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSightings.Location = new System.Drawing.Point(368, 678);
            this.btnShowSightings.Name = "btnShowSightings";
            this.btnShowSightings.Size = new System.Drawing.Size(119, 37);
            this.btnShowSightings.TabIndex = 76;
            this.btnShowSightings.Text = "Show Sightings";
            this.btnShowSightings.UseVisualStyleBackColor = true;
            this.btnShowSightings.Click += new System.EventHandler(this.ShowSightingsClick);
            // 
            // btnHideSightings
            // 
            this.btnHideSightings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideSightings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideSightings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideSightings.Location = new System.Drawing.Point(368, 678);
            this.btnHideSightings.Name = "btnHideSightings";
            this.btnHideSightings.Size = new System.Drawing.Size(119, 37);
            this.btnHideSightings.TabIndex = 77;
            this.btnHideSightings.Text = "Hide Sightings";
            this.btnHideSightings.UseVisualStyleBackColor = true;
            this.btnHideSightings.Visible = false;
            this.btnHideSightings.Click += new System.EventHandler(this.HideSightingsClick);
            // 
            // cameraPresentationBindingSource
            // 
            this.cameraPresentationBindingSource.DataSource = typeof(Model_Library.CameraPresentation);
            // 
            // sightingPresentationBindingSource
            // 
            this.sightingPresentationBindingSource.DataSource = typeof(Model_Library.SightingPresentation);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(31, 81);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(185, 13);
            this.lblAstericks.TabIndex = 78;
            this.lblAstericks.Text = "All Required Fields Marked by *";
            // 
            // CameraDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 770);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.btnHideSightings);
            this.Controls.Add(this.btnShowSightings);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeThreshold);
            this.Controls.Add(this.txtSpeedThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCameraType);
            this.Controls.Add(this.lblCameraType);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtRoadNumber);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvSightings);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblRoadNumber);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblRoadName);
            this.Controls.Add(this.lblCameraDetails);
            this.Controls.Add(this.txtRoadName);
            this.Controls.Add(this.btnClose);
            this.Name = "CameraDetailsPage";
            this.Text = "CameraDetailsPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSightings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingCarPresentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPresentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingPresentationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSelectAddress;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dgvSightings;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblRoadNumber;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblRoadName;
        private System.Windows.Forms.Label lblCameraDetails;
        public System.Windows.Forms.TextBox txtRoadName;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtRoadNumber;
        public System.Windows.Forms.TextBox txtLongitude;
        public System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblCameraType;
        public System.Windows.Forms.ComboBox cmbCameraType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSpeedThreshold;
        public System.Windows.Forms.TextBox txtTimeThreshold;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnShowSightings;
        public System.Windows.Forms.Button btnHideSightings;
        private System.Windows.Forms.BindingSource cameraPresentationBindingSource;
        private System.Windows.Forms.BindingSource sightingPresentationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sightingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondsAfterRedLightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sightingCarPresentationBindingSource;
        private System.Windows.Forms.Label lblAstericks;
    }
}
