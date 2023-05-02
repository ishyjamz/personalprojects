using Model_Library;

namespace Presentation_Tier
{
    partial class CarsPage
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
            this.btnHome = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.lblRoadName = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblColour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.colourPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColourName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.modelPresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.makePresentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAstericks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colourPresentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPresentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePresentationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(245, 95);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRegNumber.TabIndex = 1;
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(355, 12);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(130, 55);
            this.lblCars.TabIndex = 5;
            this.lblCars.Text = "Cars";
            // 
            // lblRoadName
            // 
            this.lblRoadName.AutoSize = true;
            this.lblRoadName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadName.Location = new System.Drawing.Point(69, 93);
            this.lblRoadName.Name = "lblRoadName";
            this.lblRoadName.Size = new System.Drawing.Size(155, 20);
            this.lblRoadName.TabIndex = 6;
            this.lblRoadName.Text = "Registration Number";
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(295, 219);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(106, 37);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(69, 132);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(55, 20);
            this.lblColour.TabIndex = 11;
            this.lblColour.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Make";
            // 
            // cmbColour
            // 
            this.cmbColour.DataSource = this.colourPresentationBindingSource;
            this.cmbColour.DisplayMember = "Name";
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Location = new System.Drawing.Point(245, 134);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(156, 21);
            this.cmbColour.TabIndex = 15;
            this.cmbColour.ValueMember = "ColourId";
            // 
            // colourPresentationBindingSource
            // 
            this.colourPresentationBindingSource.DataSource = typeof(Model_Library.ColourPresentation);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(69, 172);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(136, 20);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "Owner First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(245, 174);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNumberDataGridViewTextBoxColumn,
            this.ModelName,
            this.MakeName,
            this.ColourName,
            this.RegDate,
            this.OwnerFirstName,
            this.OwnerSurname,
            this.OwnerID,
            this.CarID});
            this.dgvCars.DataSource = this.carBindingSource;
            this.dgvCars.Location = new System.Drawing.Point(54, 308);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(744, 344);
            this.dgvCars.TabIndex = 22;
            this.dgvCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCars_CellDoubleClick);
            // 
            // regNumberDataGridViewTextBoxColumn
            // 
            this.regNumberDataGridViewTextBoxColumn.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.HeaderText = "Registration Number";
            this.regNumberDataGridViewTextBoxColumn.Name = "regNumberDataGridViewTextBoxColumn";
            this.regNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ModelName
            // 
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "Model";
            this.ModelName.Name = "ModelName";
            this.ModelName.ReadOnly = true;
            // 
            // MakeName
            // 
            this.MakeName.DataPropertyName = "MakeName";
            this.MakeName.HeaderText = "Make";
            this.MakeName.Name = "MakeName";
            this.MakeName.ReadOnly = true;
            // 
            // ColourName
            // 
            this.ColourName.DataPropertyName = "ColourName";
            this.ColourName.HeaderText = "Colour";
            this.ColourName.Name = "ColourName";
            this.ColourName.ReadOnly = true;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            this.RegDate.HeaderText = "Registration Date";
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            // 
            // OwnerFirstName
            // 
            this.OwnerFirstName.DataPropertyName = "OwnerFirstName";
            this.OwnerFirstName.HeaderText = "Owner First Name";
            this.OwnerFirstName.Name = "OwnerFirstName";
            this.OwnerFirstName.ReadOnly = true;
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.DataPropertyName = "OwnerSurname";
            this.OwnerSurname.HeaderText = "Owner Surname";
            this.OwnerSurname.Name = "OwnerSurname";
            this.OwnerSurname.ReadOnly = true;
            // 
            // OwnerID
            // 
            this.OwnerID.DataPropertyName = "OwnerID";
            this.OwnerID.HeaderText = "OwnerID";
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.ReadOnly = true;
            this.OwnerID.Visible = false;
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "CarID";
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Visible = false;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Model_Library.CarPresentation);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(710, 272);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(87, 30);
            this.btnAddCar.TabIndex = 23;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(626, 176);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 18;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(453, 176);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(124, 20);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Owner Surname";
            // 
            // cmbModel
            // 
            this.cmbModel.DataSource = this.modelPresentationBindingSource;
            this.cmbModel.DisplayMember = "Name";
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(626, 132);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(156, 21);
            this.cmbModel.TabIndex = 21;
            this.cmbModel.ValueMember = "ModelId";
            // 
            // modelPresentationBindingSource
            // 
            this.modelPresentationBindingSource.DataSource = typeof(Model_Library.ModelPresentation);
            // 
            // cmbMake
            // 
            this.cmbMake.DataSource = this.makePresentationBindingSource;
            this.cmbMake.DisplayMember = "Name";
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(626, 93);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(156, 21);
            this.cmbMake.TabIndex = 20;
            this.cmbMake.ValueMember = "MakeID";
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.CmbMake_SelectedIndexChanged);
            // 
            // makePresentationBindingSource
            // 
            this.makePresentationBindingSource.DataSource = typeof(Model_Library.MakePresentation);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(445, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 37);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset Filters";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblAstericks
            // 
            this.lblAstericks.AutoSize = true;
            this.lblAstericks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstericks.Location = new System.Drawing.Point(316, 292);
            this.lblAstericks.Name = "lblAstericks";
            this.lblAstericks.Size = new System.Drawing.Size(235, 13);
            this.lblAstericks.TabIndex = 80;
            this.lblAstericks.Text = "Click on a row in the grid to view details";
            // 
            // CarsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 719);
            this.Controls.Add(this.lblAstericks);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblRoadName);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.btnHome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CarsPage";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.colourPresentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPresentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePresentationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Label lblRoadName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.BindingSource colourPresentationBindingSource;
        private System.Windows.Forms.BindingSource modelPresentationBindingSource;
        private System.Windows.Forms.BindingSource makePresentationBindingSource;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColourName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.Label lblAstericks;
    }
}

