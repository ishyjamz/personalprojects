namespace Presentation_Tier
{
    partial class SearchAddressPage
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
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddressSearch = new System.Windows.Forms.Label();
            this.btnSearchAddress = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.dgvAddressTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPresentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.AutoGenerateColumns = false;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIdDataGridViewTextBoxColumn,
            this.line1DataGridViewTextBoxColumn,
            this.line2DataGridViewTextBoxColumn,
            this.line3DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countyDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn});
            this.dgvAddress.DataSource = this.addressPresentationBindingSource;
            this.dgvAddress.Location = new System.Drawing.Point(42, 283);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.Size = new System.Drawing.Size(769, 401);
            this.dgvAddress.TabIndex = 72;
            this.dgvAddress.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressGridClick);
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // line1DataGridViewTextBoxColumn
            // 
            this.line1DataGridViewTextBoxColumn.DataPropertyName = "Line1";
            this.line1DataGridViewTextBoxColumn.HeaderText = "Line 1";
            this.line1DataGridViewTextBoxColumn.Name = "line1DataGridViewTextBoxColumn";
            this.line1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // line2DataGridViewTextBoxColumn
            // 
            this.line2DataGridViewTextBoxColumn.DataPropertyName = "Line2";
            this.line2DataGridViewTextBoxColumn.HeaderText = "Line 2";
            this.line2DataGridViewTextBoxColumn.Name = "line2DataGridViewTextBoxColumn";
            this.line2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // line3DataGridViewTextBoxColumn
            // 
            this.line3DataGridViewTextBoxColumn.DataPropertyName = "Line3";
            this.line3DataGridViewTextBoxColumn.HeaderText = "Line 3";
            this.line3DataGridViewTextBoxColumn.Name = "line3DataGridViewTextBoxColumn";
            this.line3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countyDataGridViewTextBoxColumn
            // 
            this.countyDataGridViewTextBoxColumn.DataPropertyName = "County";
            this.countyDataGridViewTextBoxColumn.HeaderText = "County";
            this.countyDataGridViewTextBoxColumn.Name = "countyDataGridViewTextBoxColumn";
            this.countyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressPresentationBindingSource
            // 
            this.addressPresentationBindingSource.DataSource = typeof(Model_Library.AddressPresentation);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(169, 162);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 20);
            this.txtCity.TabIndex = 71;
            // 
            // lblAddressSearch
            // 
            this.lblAddressSearch.AutoSize = true;
            this.lblAddressSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressSearch.Location = new System.Drawing.Point(251, 22);
            this.lblAddressSearch.Name = "lblAddressSearch";
            this.lblAddressSearch.Size = new System.Drawing.Size(381, 55);
            this.lblAddressSearch.TabIndex = 70;
            this.lblAddressSearch.Text = "Address Search";
            // 
            // btnSearchAddress
            // 
            this.btnSearchAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAddress.Location = new System.Drawing.Point(346, 209);
            this.btnSearchAddress.Name = "btnSearchAddress";
            this.btnSearchAddress.Size = new System.Drawing.Size(169, 49);
            this.btnSearchAddress.TabIndex = 69;
            this.btnSearchAddress.Text = "Search Address";
            this.btnSearchAddress.UseVisualStyleBackColor = true;
            this.btnSearchAddress.Click += new System.EventHandler(this.SearchAddressClick);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(518, 165);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(76, 20);
            this.lblDOB.TabIndex = 66;
            this.lblDOB.Text = "Postcode";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(518, 123);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 65;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(38, 162);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 64;
            this.lblCity.Text = "City";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine1.Location = new System.Drawing.Point(38, 123);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(52, 20);
            this.lblLine1.TabIndex = 63;
            this.lblLine1.Text = "Line 1";
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(169, 123);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(187, 20);
            this.txtLine1.TabIndex = 62;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(655, 125);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(156, 20);
            this.txtCountry.TabIndex = 73;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(655, 167);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(127, 20);
            this.txtPostcode.TabIndex = 74;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(30, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddress.Location = new System.Drawing.Point(655, 232);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(156, 45);
            this.btnAddAddress.TabIndex = 76;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            // 
            // dgvAddressTable
            // 
            this.dgvAddressTable.AllowUserToAddRows = false;
            this.dgvAddressTable.AllowUserToDeleteRows = false;
            this.dgvAddressTable.AutoGenerateColumns = false;
            this.dgvAddressTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvAddressTable.DataSource = this.addressPresentationBindingSource;
            this.dgvAddressTable.Location = new System.Drawing.Point(42, 283);
            this.dgvAddressTable.Name = "dgvAddressTable";
            this.dgvAddressTable.ReadOnly = true;
            this.dgvAddressTable.Size = new System.Drawing.Size(769, 401);
            this.dgvAddressTable.TabIndex = 77;
            this.dgvAddressTable.Visible = false;
            this.dgvAddressTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressTableClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AddressId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AddressId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Line1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Line 1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Line2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Line 2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Line3";
            this.dataGridViewTextBoxColumn4.HeaderText = "Line 3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "County";
            this.dataGridViewTextBoxColumn6.HeaderText = "County";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn7.HeaderText = "Country";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PostalCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // SearchAddressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 696);
            this.Controls.Add(this.dgvAddressTable);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.dgvAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddressSearch);
            this.Controls.Add(this.btnSearchAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.txtLine1);
            this.Name = "SearchAddressPage";
            this.Text = "SearchAddressPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPresentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddress;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddressSearch;
        public System.Windows.Forms.Button btnSearchAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLine1;
        public System.Windows.Forms.TextBox txtLine1;
        public System.Windows.Forms.TextBox txtCountry;
        public System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressPresentationBindingSource;
        public System.Windows.Forms.DataGridView dgvAddressTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
