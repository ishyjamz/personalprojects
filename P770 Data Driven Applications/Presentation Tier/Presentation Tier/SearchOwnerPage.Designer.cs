using Model_Library;
namespace Presentation_Tier
{
    partial class SearchOwnerPage
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
            this.btnSearchOwner = new System.Windows.Forms.Button();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblOwnerSurname = new System.Windows.Forms.Label();
            this.lblOwnerFirstName = new System.Windows.Forms.Label();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtOwnerSurname = new System.Windows.Forms.TextBox();
            this.dgvOwner = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchOwner
            // 
            this.btnSearchOwner.Enabled = false;
            this.btnSearchOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOwner.Location = new System.Drawing.Point(228, 255);
            this.btnSearchOwner.Name = "btnSearchOwner";
            this.btnSearchOwner.Size = new System.Drawing.Size(107, 48);
            this.btnSearchOwner.TabIndex = 58;
            this.btnSearchOwner.Text = "Search Owner";
            this.btnSearchOwner.UseVisualStyleBackColor = true;
            this.btnSearchOwner.Click += new System.EventHandler(this.BtnSearchOwner_Click_1);
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(360, 135);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine1.TabIndex = 49;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblOwnerSurname
            // 
            this.lblOwnerSurname.AutoSize = true;
            this.lblOwnerSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerSurname.Location = new System.Drawing.Point(24, 176);
            this.lblOwnerSurname.Name = "lblOwnerSurname";
            this.lblOwnerSurname.Size = new System.Drawing.Size(74, 20);
            this.lblOwnerSurname.TabIndex = 48;
            this.lblOwnerSurname.Text = "Surname";
            // 
            // lblOwnerFirstName
            // 
            this.lblOwnerFirstName.AutoSize = true;
            this.lblOwnerFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOwnerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerFirstName.Location = new System.Drawing.Point(24, 133);
            this.lblOwnerFirstName.Name = "lblOwnerFirstName";
            this.lblOwnerFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblOwnerFirstName.TabIndex = 47;
            this.lblOwnerFirstName.Text = "First Name";
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Enabled = false;
            this.txtOwnerFirstName.Location = new System.Drawing.Point(159, 135);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtOwnerFirstName.TabIndex = 46;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(191, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(344, 55);
            this.lblSearch.TabIndex = 59;
            this.lblSearch.Text = "Owner Search";
            // 
            // txtOwnerSurname
            // 
            this.txtOwnerSurname.Enabled = false;
            this.txtOwnerSurname.Location = new System.Drawing.Point(159, 178);
            this.txtOwnerSurname.Name = "txtOwnerSurname";
            this.txtOwnerSurname.Size = new System.Drawing.Size(158, 20);
            this.txtOwnerSurname.TabIndex = 60;
            // 
            // dgvOwner
            // 
            this.dgvOwner.AutoGenerateColumns = false;
            this.dgvOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.Line1,
            this.Country,
            this.Postcode,
            this.OwnerId});
            this.dgvOwner.DataSource = this.ownerBindingSource;
            this.dgvOwner.Location = new System.Drawing.Point(28, 345);
            this.dgvOwner.Name = "dgvOwner";
            this.dgvOwner.Size = new System.Drawing.Size(644, 340);
            this.dgvOwner.TabIndex = 61;
            this.dgvOwner.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOwner_CellDoubleClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // Line1
            // 
            this.Line1.DataPropertyName = "Line1";
            this.Line1.HeaderText = "Line1";
            this.Line1.Name = "Line1";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Postcode
            // 
            this.Postcode.DataPropertyName = "Postcode";
            this.Postcode.HeaderText = "Postcode";
            this.Postcode.Name = "Postcode";
            // 
            // OwnerId
            // 
            this.OwnerId.DataPropertyName = "OwnerId";
            this.OwnerId.HeaderText = "OwnerId";
            this.OwnerId.Name = "OwnerId";
            this.OwnerId.Visible = false;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataSource = typeof(Model_Library.OwnerPresentation);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(28, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Enabled = false;
            this.txtAddressLine1.Location = new System.Drawing.Point(493, 135);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(179, 20);
            this.txtAddressLine1.TabIndex = 78;
            // 
            // txtCountry
            // 
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(533, 176);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(139, 20);
            this.txtCountry.TabIndex = 80;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(360, 176);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 79;
            this.lblCountry.Text = "Country";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Enabled = false;
            this.txtPostcode.Location = new System.Drawing.Point(533, 217);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(139, 20);
            this.txtPostcode.TabIndex = 82;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(360, 217);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 20);
            this.lblPostcode.TabIndex = 81;
            this.lblPostcode.Text = "Postcode";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(368, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 48);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(159, 219);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 20);
            this.txtCity.TabIndex = 92;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(26, 217);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 91;
            this.lblCity.Text = "City";
            // 
            // SearchOwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 723);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOwner);
            this.Controls.Add(this.txtOwnerSurname);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearchOwner);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblOwnerSurname);
            this.Controls.Add(this.lblOwnerFirstName);
            this.Controls.Add(this.txtOwnerFirstName);
            this.Name = "SearchOwnerPage";
            this.Text = "SearchOwner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSearchOwner;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblOwnerSurname;
        private System.Windows.Forms.Label lblOwnerFirstName;
        public System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox txtOwnerSurname;
        private System.Windows.Forms.DataGridView dgvOwner;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtAddressLine1;
        public System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerId;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
    }
}
