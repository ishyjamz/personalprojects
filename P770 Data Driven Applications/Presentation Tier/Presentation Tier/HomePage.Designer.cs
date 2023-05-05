namespace Presentation_Tier
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnOwners = new System.Windows.Forms.Button();
            this.btnCameras = new System.Windows.Forms.Button();
            this.lblPleaseClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetails.Location = new System.Drawing.Point(266, 9);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(207, 73);
            this.lblCarDetails.TabIndex = 27;
            this.lblCarDetails.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Welcome to my DVLA Database Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 445);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.Location = new System.Drawing.Point(30, 177);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(196, 60);
            this.btnCars.TabIndex = 30;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.BtnCars_Click);
            // 
            // btnOwners
            // 
            this.btnOwners.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOwners.FlatAppearance.BorderSize = 0;
            this.btnOwners.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwners.Location = new System.Drawing.Point(267, 177);
            this.btnOwners.Name = "btnOwners";
            this.btnOwners.Size = new System.Drawing.Size(196, 60);
            this.btnOwners.TabIndex = 31;
            this.btnOwners.Text = "Owners";
            this.btnOwners.UseVisualStyleBackColor = false;
            this.btnOwners.Click += new System.EventHandler(this.BtnOwners_Click);
            // 
            // btnCameras
            // 
            this.btnCameras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCameras.FlatAppearance.BorderSize = 0;
            this.btnCameras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCameras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameras.Location = new System.Drawing.Point(506, 177);
            this.btnCameras.Name = "btnCameras";
            this.btnCameras.Size = new System.Drawing.Size(196, 60);
            this.btnCameras.TabIndex = 32;
            this.btnCameras.Text = "Cameras";
            this.btnCameras.UseVisualStyleBackColor = false;
            this.btnCameras.Click += new System.EventHandler(this.BtnCameras_Click);
            // 
            // lblPleaseClick
            // 
            this.lblPleaseClick.AutoSize = true;
            this.lblPleaseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseClick.Location = new System.Drawing.Point(175, 142);
            this.lblPleaseClick.Name = "lblPleaseClick";
            this.lblPleaseClick.Size = new System.Drawing.Size(388, 20);
            this.lblPleaseClick.TabIndex = 33;
            this.lblPleaseClick.Text = "Please select which page you would like to navigate to";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 719);
            this.Controls.Add(this.lblPleaseClick);
            this.Controls.Add(this.btnCameras);
            this.Controls.Add(this.btnOwners);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCarDetails);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnOwners;
        private System.Windows.Forms.Button btnCameras;
        private System.Windows.Forms.Label lblPleaseClick;
    }
}
