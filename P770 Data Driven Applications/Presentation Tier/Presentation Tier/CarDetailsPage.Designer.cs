using Model_Library;
namespace Presentation_Tier
{
    partial class CarDetailsPage
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
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.dgvSightings = new System.Windows.Forms.DataGridView();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sightingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondsAfterRedLightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sightingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.colourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSelectOwner = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sightingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnShowSightings = new System.Windows.Forms.Button();
            this.btnHideSightings = new System.Windows.Forms.Button();
            this.btnAddOwnerCar = new System.Windows.Forms.Button();
            this.lblAstericks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSightings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(502, 284);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(94, 37);
            this.btnCancelEdit.TabIndex = 40;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // dgvSightings
            // 
            this.dgvSightings.AllowUserToAddRows = false;
            this.dgvSightings.AllowUserToDeleteRows = false;
            this.dgvSightings.AutoGenerateColumns = false;
            this.dgvSightings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSightings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNumberDataGridViewTextBoxColumn,
            this.sightingTimeDataGridViewTextBoxColumn,
            this.secondsAfterRedLightDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.datePaidDataGridViewTextBoxColumn});
            this.dgvSightings.DataSource = this.sightingCarBindingSource;
            this.dgvSightings.Location = new System.Drawing.Point(112, 335);
            this.dgvSightings.Name = "dgvSightings";
            this.dgvSightings.ReadOnly = true;
            this.dgvSightings.Size = new System.Drawing.Size(645, 344);
            this.dgvSightings.TabIndex = 39;
            this.dgvSightings.Visible = false;
            // 
            // regNumberDataGridViewTextBoxColumn
            // 
            this.regNumberDataGridViewTextBoxColumn.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.regNumberDataGridViewTextBoxColumn.Name = "regNumberDataGridViewTextBoxColumn";
            this.regNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sightingTimeDataGridViewTextBoxColumn
            // 
            this.sightingTimeDataGridViewTextBoxColumn.DataPropertyName = "SightingTime";
            this.sightingTimeDataGridViewTextBoxColumn.HeaderText = "Sighting Time";
            this.sightingTimeDataGridViewTextBoxColumn.Name = "sightingTimeDataGridViewTextBoxColumn";
            this.sightingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondsAfterRedLightDataGridViewTextBoxColumn
            // 
            this.secondsAfterRedLightDataGridViewTextBoxColumn.DataPropertyName = "SecondsAfterRedLight";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.HeaderText = "Time After Red Light (s)";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.Name = "secondsAfterRedLightDataGridViewTextBoxColumn";
            this.secondsAfterRedLightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed (mph)";
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
            // sightingCarBindingSource
            // 
            this.sightingCarBindingSource.DataSource = typeof(Model_Library.SightingCarPresentation);
            // 
            // cmbModel
            // 
            this.cmbModel.DataSource = this.modelBindingSource;
            this.cmbModel.DisplayMember = "Name";
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(666, 153);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(156, 21);
            this.cmbModel.TabIndex = 38;
            this.cmbModel.ValueMember = "ModelId";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(Model_Library.ModelPresentation);
            // 
            // cmbMake
            // 
            this.cmbMake.DataSource = this.makeBindingSource;
            this.cmbMake.DisplayMember = "Name";
            this.cmbMake.Enabled = false;
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(666, 114);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(156, 21);
            this.cmbMake.TabIndex = 37;
            this.cmbMake.ValueMember = "MakeID";
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.CmbMake_SelectedIndexChanged);
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataSource = typeof(Model_Library.MakePresentation);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(493, 197);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(144, 20);
            this.lblSurname.TabIndex = 36;
            this.lblSurname.Text = "Registration Date *";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(29, 195);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 20);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "Owner *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(112, 195);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 33;
            // 
            // cmbColour
            // 
            this.cmbColour.DataSource = this.colourBindingSource;
            this.cmbColour.DisplayMember = "Name";
            this.cmbColour.Enabled = false;
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Location = new System.Drawing.Point(205, 157);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(156, 21);
            this.cmbColour.TabIndex = 32;
            this.cmbColour.ValueMember = "ColourId";
            // 
            // colourBindingSource
            // 
            this.colourBindingSource.DataSource = typeof(Model_Library.ColourPresentation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Model *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Make *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Colour *";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(386, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 37);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNumber.Location = new System.Drawing.Point(29, 116);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(165, 20);
            this.lblRegNumber.TabIndex = 27;
            this.lblRegNumber.Text = "Registration Number *";
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetails.Location = new System.Drawing.Point(316, 33);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(272, 55);
            this.lblCarDetails.TabIndex = 26;
            this.lblCarDetails.Text = "Car Details";
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Enabled = false;
            this.txtRegNumber.Location = new System.Drawing.Point(205, 118);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRegNumber.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(30, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Enabled = false;
            this.dtpRegDate.Location = new System.Drawing.Point(666, 197);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(156, 20);
            this.dtpRegDate.TabIndex = 41;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.Location = new System.Drawing.Point(264, 284);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(94, 37);
            this.btnSaveEdit.TabIndex = 42;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Visible = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.Enabled = false;
            this.btnSelectOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOwner.Location = new System.Drawing.Point(366, 191);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(93, 30);
            this.btnSelectOwner.TabIndex = 45;
            this.btnSelectOwner.Text = "Select Owner";
            this.btnSelectOwner.UseVisualStyleBackColor = true;
            this.btnSelectOwner.Click += new System.EventHandler(this.BtnSelectOwner_Click);
            // 
            // sightingBindingSource
            // 
            this.sightingBindingSource.DataSource = typeof(Model_Library.SightingPresentation);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Model_Library.CarPresentation);
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataSource = typeof(Model_Library.CarPresentation);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(618, 284);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(94, 37);
            this.btnCancelAdd.TabIndex = 46;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Visible = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.BtnCancelAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(139, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnSaveAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(239, 195);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 48;
            // 
            // btnShowSightings
            // 
            this.btnShowSightings.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnShowSightings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSightings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSightings.Location = new System.Drawing.Point(366, 686);
            this.btnShowSightings.Name = "btnShowSightings";
            this.btnShowSightings.Size = new System.Drawing.Size(124, 37);
            this.btnShowSightings.TabIndex = 49;
            this.btnShowSightings.Text = "Show Sightings";
            this.btnShowSightings.UseVisualStyleBackColor = true;
            this.btnShowSightings.Click += new System.EventHandler(this.BtnShowSightings_Click);
            // 
            // btnHideSightings
            // 
            this.btnHideSightings.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btnHideSightings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideSightings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideSightings.Location = new System.Drawing.Point(366, 685);
            this.btnHideSightings.Name = "btnHideSightings";
            this.btnHideSightings.Size = new System.Drawing.Size(124, 37);
            this.btnHideSightings.TabIndex = 50;
            this.btnHideSightings.Text = "Hide Sightings";
            this.btnHideSightings.UseVisualStyleBackColor = true;
            this.btnHideSightings.Visible = false;
            this.btnHideSightings.Click += new System.EventHandler(this.BtnHideSightings_Click);
            // 
            // btnAddOwnerCar
            // 
            this.btnAddOwnerCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOwnerCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwnerCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwnerCar.Location = new System.Drawing.Point(139, 284);
            this.btnAddOwnerCar.Name = "btnAddOwnerCar";
            this.btnAddOwnerCar.Size = new System.Drawing.Size(94, 37);
            this.btnAddOwnerCar.TabIndex = 51;
            this.btnAddOwnerCar.Text = "Add ";
            this.btnAddOwnerCar.UseVisualStyleBackColor = true;
            this.btnAddOwnerCar.Visible = false;
            this.btnAddOwnerCar.Click += new System.EventHandler(this.AddOwnerCar);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(30, 92);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(185, 13);
            this.lblAstericks.TabIndex = 79;
            this.lblAstericks.Text = "All Required Fields Marked by *";
            // 
            // CarDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 739);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.btnAddOwnerCar);
            this.Controls.Add(this.btnHideSightings);
            this.Controls.Add(this.btnShowSightings);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnSelectOwner);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.dtpRegDate);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.dgvSightings);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblRegNumber);
            this.Controls.Add(this.lblCarDetails);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.btnClose);
            this.Name = "CarDetailsPage";
            this.Text = "Car Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSightings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.DataGridView dgvSightings;
        public System.Windows.Forms.ComboBox cmbModel;
        public System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label lblCarDetails;
        public System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DateTimePicker dtpRegDate;
        public System.Windows.Forms.Button btnSaveEdit;
        public System.Windows.Forms.Button btnSelectOwner;
        private System.Windows.Forms.BindingSource sightingBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingSource sightingCarBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private System.Windows.Forms.BindingSource colourBindingSource;
        public System.Windows.Forms.Button btnCancelAdd;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sightingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondsAfterRedLightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaidDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnShowSightings;
        public System.Windows.Forms.Button btnHideSightings;
        public System.Windows.Forms.Button btnAddOwnerCar;
        private System.Windows.Forms.Label lblAstericks;
    }
}
