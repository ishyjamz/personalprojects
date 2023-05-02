namespace Presentation_Tier
{
    partial class CamerasPage
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.dgvCameras = new System.Windows.Forms.DataGridView();
            this.cameraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeedThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtLatTo = new System.Windows.Forms.TextBox();
            this.txtLatFrom = new System.Windows.Forms.TextBox();
            this.txtLongTo = new System.Windows.Forms.TextBox();
            this.lblLongitudeRange = new System.Windows.Forms.Label();
            this.txtLongFrom = new System.Windows.Forms.TextBox();
            this.lblLatitudeRange = new System.Windows.Forms.Label();
            this.lblRoadNumber = new System.Windows.Forms.Label();
            this.lblRoadName = new System.Windows.Forms.Label();
            this.txtRoadName = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtRoadNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHideResults = new System.Windows.Forms.Button();
            this.lblAstericks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPresentationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(649, 272);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(133, 37);
            this.btnAddCar.TabIndex = 40;
            this.btnAddCar.Text = "Add Camera";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.AddCameraClick);
            // 
            // dgvCameras
            // 
            this.dgvCameras.AllowUserToAddRows = false;
            this.dgvCameras.AllowUserToDeleteRows = false;
            this.dgvCameras.AutoGenerateColumns = false;
            this.dgvCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCameras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cameraIdDataGridViewTextBoxColumn,
            this.addressIdDataGridViewTextBoxColumn,
            this.roadNameDataGridViewTextBoxColumn,
            this.roadNumberDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.SpeedThreshold,
            this.TimeThreshold,
            this.Line1});
            this.dgvCameras.DataSource = this.cameraPresentationBindingSource;
            this.dgvCameras.Location = new System.Drawing.Point(71, 315);
            this.dgvCameras.Name = "dgvCameras";
            this.dgvCameras.ReadOnly = true;
            this.dgvCameras.Size = new System.Drawing.Size(711, 344);
            this.dgvCameras.TabIndex = 39;
            this.dgvCameras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CameraRowClick);
            // 
            // cameraIdDataGridViewTextBoxColumn
            // 
            this.cameraIdDataGridViewTextBoxColumn.DataPropertyName = "CameraId";
            this.cameraIdDataGridViewTextBoxColumn.HeaderText = "CameraId";
            this.cameraIdDataGridViewTextBoxColumn.Name = "cameraIdDataGridViewTextBoxColumn";
            this.cameraIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cameraIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // roadNameDataGridViewTextBoxColumn
            // 
            this.roadNameDataGridViewTextBoxColumn.DataPropertyName = "RoadName";
            this.roadNameDataGridViewTextBoxColumn.HeaderText = "Road Name";
            this.roadNameDataGridViewTextBoxColumn.Name = "roadNameDataGridViewTextBoxColumn";
            this.roadNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roadNumberDataGridViewTextBoxColumn
            // 
            this.roadNumberDataGridViewTextBoxColumn.DataPropertyName = "RoadNumber";
            this.roadNumberDataGridViewTextBoxColumn.HeaderText = "Road Number";
            this.roadNumberDataGridViewTextBoxColumn.Name = "roadNumberDataGridViewTextBoxColumn";
            this.roadNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SpeedThreshold
            // 
            this.SpeedThreshold.DataPropertyName = "SpeedThreshold";
            this.SpeedThreshold.HeaderText = "SpeedThreshold";
            this.SpeedThreshold.Name = "SpeedThreshold";
            this.SpeedThreshold.ReadOnly = true;
            // 
            // TimeThreshold
            // 
            this.TimeThreshold.DataPropertyName = "TimeThreshold";
            this.TimeThreshold.HeaderText = "TimeThreshold";
            this.TimeThreshold.Name = "TimeThreshold";
            this.TimeThreshold.ReadOnly = true;
            // 
            // Line1
            // 
            this.Line1.DataPropertyName = "Line1";
            this.Line1.HeaderText = "Line1";
            this.Line1.Name = "Line1";
            this.Line1.ReadOnly = true;
            // 
            // cameraPresentationBindingSource
            // 
            this.cameraPresentationBindingSource.DataSource = typeof(Model_Library.CameraPresentation);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(282, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 37);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.CameraSearch);
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(315, 12);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(227, 55);
            this.lblCars.TabIndex = 26;
            this.lblCars.Text = "Cameras";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(10, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 40);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // txtLatTo
            // 
            this.txtLatTo.Location = new System.Drawing.Point(704, 139);
            this.txtLatTo.Name = "txtLatTo";
            this.txtLatTo.Size = new System.Drawing.Size(64, 20);
            this.txtLatTo.TabIndex = 50;
            // 
            // txtLatFrom
            // 
            this.txtLatFrom.Location = new System.Drawing.Point(603, 139);
            this.txtLatFrom.Name = "txtLatFrom";
            this.txtLatFrom.Size = new System.Drawing.Size(64, 20);
            this.txtLatFrom.TabIndex = 49;
            // 
            // txtLongTo
            // 
            this.txtLongTo.Location = new System.Drawing.Point(704, 104);
            this.txtLongTo.Name = "txtLongTo";
            this.txtLongTo.Size = new System.Drawing.Size(64, 20);
            this.txtLongTo.TabIndex = 48;
            // 
            // lblLongitudeRange
            // 
            this.lblLongitudeRange.AutoSize = true;
            this.lblLongitudeRange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLongitudeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitudeRange.Location = new System.Drawing.Point(433, 102);
            this.lblLongitudeRange.Name = "lblLongitudeRange";
            this.lblLongitudeRange.Size = new System.Drawing.Size(132, 20);
            this.lblLongitudeRange.TabIndex = 47;
            this.lblLongitudeRange.Text = "Longitude Range";
            // 
            // txtLongFrom
            // 
            this.txtLongFrom.Location = new System.Drawing.Point(603, 104);
            this.txtLongFrom.Name = "txtLongFrom";
            this.txtLongFrom.Size = new System.Drawing.Size(64, 20);
            this.txtLongFrom.TabIndex = 46;
            // 
            // lblLatitudeRange
            // 
            this.lblLatitudeRange.AutoSize = true;
            this.lblLatitudeRange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLatitudeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitudeRange.Location = new System.Drawing.Point(433, 142);
            this.lblLatitudeRange.Name = "lblLatitudeRange";
            this.lblLatitudeRange.Size = new System.Drawing.Size(119, 20);
            this.lblLatitudeRange.TabIndex = 44;
            this.lblLatitudeRange.Text = "Latitude Range";
            // 
            // lblRoadNumber
            // 
            this.lblRoadNumber.AutoSize = true;
            this.lblRoadNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadNumber.Location = new System.Drawing.Point(67, 142);
            this.lblRoadNumber.Name = "lblRoadNumber";
            this.lblRoadNumber.Size = new System.Drawing.Size(108, 20);
            this.lblRoadNumber.TabIndex = 43;
            this.lblRoadNumber.Text = "Road Number";
            // 
            // lblRoadName
            // 
            this.lblRoadName.AutoSize = true;
            this.lblRoadName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadName.Location = new System.Drawing.Point(67, 102);
            this.lblRoadName.Name = "lblRoadName";
            this.lblRoadName.Size = new System.Drawing.Size(94, 20);
            this.lblRoadName.TabIndex = 42;
            this.lblRoadName.Text = "Road Name";
            // 
            // txtRoadName
            // 
            this.txtRoadName.Location = new System.Drawing.Point(218, 104);
            this.txtRoadName.Name = "txtRoadName";
            this.txtRoadName.Size = new System.Drawing.Size(156, 20);
            this.txtRoadName.TabIndex = 41;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(611, 81);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 20);
            this.lblFrom.TabIndex = 51;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(713, 81);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 20);
            this.lblTo.TabIndex = 52;
            this.lblTo.Text = "To";
            // 
            // txtRoadNumber
            // 
            this.txtRoadNumber.Location = new System.Drawing.Point(218, 144);
            this.txtRoadNumber.Name = "txtRoadNumber";
            this.txtRoadNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRoadNumber.TabIndex = 53;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(432, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 37);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // btnHideResults
            // 
            this.btnHideResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideResults.Location = new System.Drawing.Point(370, 665);
            this.btnHideResults.Name = "btnHideResults";
            this.btnHideResults.Size = new System.Drawing.Size(133, 37);
            this.btnHideResults.TabIndex = 55;
            this.btnHideResults.Text = "Hide Results";
            this.btnHideResults.UseVisualStyleBackColor = true;
            this.btnHideResults.Visible = false;
            this.btnHideResults.Click += new System.EventHandler(this.HideResultsClick);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(307, 296);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(235, 13);
            this.lblAstericks.TabIndex = 79;
            this.lblAstericks.Text = "Click on a row in the grid to view details";
            // 
            // CamerasPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 735);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.btnHideResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRoadNumber);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtLatTo);
            this.Controls.Add(this.txtLatFrom);
            this.Controls.Add(this.txtLongTo);
            this.Controls.Add(this.lblLongitudeRange);
            this.Controls.Add(this.txtLongFrom);
            this.Controls.Add(this.lblLatitudeRange);
            this.Controls.Add(this.lblRoadNumber);
            this.Controls.Add(this.lblRoadName);
            this.Controls.Add(this.txtRoadName);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.dgvCameras);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.btnHome);
            this.Name = "CamerasPage";
            this.Text = "Cameras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPresentationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.DataGridView dgvCameras;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtLatTo;
        private System.Windows.Forms.TextBox txtLatFrom;
        private System.Windows.Forms.TextBox txtLongTo;
        private System.Windows.Forms.Label lblLongitudeRange;
        private System.Windows.Forms.TextBox txtLongFrom;
        private System.Windows.Forms.Label lblLatitudeRange;
        private System.Windows.Forms.Label lblRoadNumber;
        private System.Windows.Forms.Label lblRoadName;
        private System.Windows.Forms.TextBox txtRoadName;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtRoadNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource cameraPresentationBindingSource;
        private System.Windows.Forms.Button btnHideResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeedThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line1;
        private System.Windows.Forms.Label lblAstericks;
    }
}
