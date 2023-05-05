namespace Presentation_Tier
{
    partial class OwnerPage
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
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.dgvOwners = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowVersion = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblOwnerSN = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblOwnerFN = new System.Windows.Forms.Label();
            this.lblOwners = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAstericks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerPresentationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwner.Location = new System.Drawing.Point(660, 281);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(111, 37);
            this.btnAddOwner.TabIndex = 40;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.BtnAddOwner_Click);
            // 
            // dgvOwners
            // 
            this.dgvOwners.AllowUserToAddRows = false;
            this.dgvOwners.AllowUserToDeleteRows = false;
            this.dgvOwners.AutoGenerateColumns = false;
            this.dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerIdDataGridViewTextBoxColumn,
            this.addressIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.line1DataGridViewTextBoxColumn,
            this.City,
            this.countryDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.RowVersion});
            this.dgvOwners.DataSource = this.ownerPresentationBindingSource;
            this.dgvOwners.Location = new System.Drawing.Point(29, 324);
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.ReadOnly = true;
            this.dgvOwners.Size = new System.Drawing.Size(742, 344);
            this.dgvOwners.TabIndex = 39;
            this.dgvOwners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OwnerDoubleClick);
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // RowVersion
            // 
            this.RowVersion.DataPropertyName = "RowVersion";
            this.RowVersion.HeaderText = "RowVersion";
            this.RowVersion.Name = "RowVersion";
            this.RowVersion.ReadOnly = true;
            this.RowVersion.Visible = false;
            // 
            // lblOwnerSN
            // 
            this.lblOwnerSN.AutoSize = true;
            this.lblOwnerSN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerSN.Location = new System.Drawing.Point(59, 147);
            this.lblOwnerSN.Name = "lblOwnerSN";
            this.lblOwnerSN.Size = new System.Drawing.Size(74, 20);
            this.lblOwnerSN.TabIndex = 29;
            this.lblOwnerSN.Text = "Surname";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(240, 236);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 37);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblOwnerFN
            // 
            this.lblOwnerFN.AutoSize = true;
            this.lblOwnerFN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerFN.Location = new System.Drawing.Point(59, 116);
            this.lblOwnerFN.Name = "lblOwnerFN";
            this.lblOwnerFN.Size = new System.Drawing.Size(86, 20);
            this.lblOwnerFN.TabIndex = 27;
            this.lblOwnerFN.Text = "First Name";
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwners.Location = new System.Drawing.Point(285, 24);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(196, 55);
            this.lblOwners.TabIndex = 26;
            this.lblOwners.Text = "Owners";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(192, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 25;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(29, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 40);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(192, 149);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 41;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.Location = new System.Drawing.Point(415, 236);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(133, 37);
            this.btnClearFilters.TabIndex = 42;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.BtnClearFilters_Click);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(566, 189);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(128, 20);
            this.txtPostcode.TabIndex = 88;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(433, 189);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 20);
            this.lblPostcode.TabIndex = 87;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(566, 151);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(152, 20);
            this.txtCountry.TabIndex = 86;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(433, 149);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 85;
            this.lblCountry.Text = "Country";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(566, 116);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(179, 20);
            this.txtAddressLine1.TabIndex = 84;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(433, 116);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine1.TabIndex = 83;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(192, 189);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 20);
            this.txtCity.TabIndex = 90;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(59, 187);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 89;
            this.lblCity.Text = "City";
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // line1DataGridViewTextBoxColumn
            // 
            this.line1DataGridViewTextBoxColumn.DataPropertyName = "Line1";
            this.line1DataGridViewTextBoxColumn.HeaderText = "Address Line 1";
            this.line1DataGridViewTextBoxColumn.Name = "line1DataGridViewTextBoxColumn";
            this.line1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            this.postcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerPresentationBindingSource
            // 
            this.ownerPresentationBindingSource.DataSource = typeof(Model_Library.OwnerPresentation);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(292, 305);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(235, 13);
            this.lblAstericks.TabIndex = 91;
            this.lblAstericks.Text = "Click on a row in the grid to view details";
            // 
            // OwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 752);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.dgvOwners);
            this.Controls.Add(this.lblOwnerSN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblOwnerFN);
            this.Controls.Add(this.lblOwners);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnHome);
            this.Name = "OwnerPage";
            this.Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerPresentationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOwner;
        public System.Windows.Forms.DataGridView dgvOwners;
        private System.Windows.Forms.Label lblOwnerSN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblOwnerFN;
        private System.Windows.Forms.Label lblOwners;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnClearFilters;
        public System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        public System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.BindingSource ownerPresentationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn RowVersion;
        private System.Windows.Forms.Label lblAstericks;
    }
}
