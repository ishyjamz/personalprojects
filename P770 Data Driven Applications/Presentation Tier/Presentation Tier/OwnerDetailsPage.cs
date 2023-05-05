using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entity_Library;
using Model_Library;

namespace Presentation_Tier
{
    public partial class OwnerDetailsPage : Form
    {
        public OwnerPresentation _Owner = new OwnerPresentation();
        public OwnerRepository _OwnerRepos = new OwnerRepository();
        public OwnerDetailsPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds new owner to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClick(object sender, EventArgs e)
        {
            _Owner.FirstName = txtFirstName.Text;
            _Owner.LastName = txtSurname.Text;
            _Owner.DateOfBirth = dtpDOB.Value;
            if (txtFirstName.Text != string.Empty && txtSurname.Text != string.Empty
                && dtpDOB.Value <= DateTime.Today)
            {
                _OwnerRepos.AddNewOwner(_Owner);
                string message = "New owner added successfully to the database";
                string title = "Message";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "One or more required fields not filled out";
                string title = "Message";
                MessageBox.Show(message, title);
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Resets all fields when cancelling the adding of a new owner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAddClick(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? " +
                "All changes will be lost";
            string warning = "Warning";
            DialogResult dialogResult = MessageBox.Show(message, warning,
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dtpDOB.Text = default(string);
                foreach (Control t in Controls)
                {
                    if (t is TextBox)
                    {
                        t.Text = string.Empty;
                    }
                    else if (t is ComboBox)
                    {
                        t.Text = string.Empty;
                    }
                }
            }
        }
        /// <summary>
        /// Allows owner details to be edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClick(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            txtFirstName.Enabled = true;
            txtSurname.Enabled = true;
            dtpDOB.Enabled = true;
            txtAddress.Enabled = true;
            btnSelectAddress.Enabled = true;
            _Owner.FirstName = txtFirstName.Text;
            _Owner.LastName = txtSurname.Text;
            _Owner.DateOfBirth = dtpDOB.Value;
            string[] addressSplit = txtAddress.Text.Split(' ');
            _Owner.Line1 = addressSplit[0];
            _Owner.City = addressSplit[1];
            _Owner.Country = addressSplit[2];
            _Owner.Postcode = addressSplit[3];
        }
        /// <summary>
        /// Opens select address page to allow user to add address to owner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAddressClick(object sender, EventArgs e)
        {
            SearchAddressPage searchAddress = new SearchAddressPage();
            searchAddress.Show();
        }
        /// <summary>
        /// Updates owner details to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClick(object sender, EventArgs e)
        {
            _Owner.FirstName = txtFirstName.Text;
            _Owner.LastName = txtSurname.Text;
            _Owner.DateOfBirth = dtpDOB.Value;
            var owner = _OwnerRepos.UpdateOwnerDetails(_Owner);
            if (owner == null)
            {
                string concMessage = "A concurrency error has occured";
                string warning = "Error";
                MessageBox.Show(concMessage, warning);
            }
            else
            {
                string message = "Owner details have been updated successfully";
                string title = "Message";
                MessageBox.Show(message, title);
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnEdit.Visible = true;
                dtpDOB.Enabled = false;
                btnSelectAddress.Enabled = false;
                var ownersPage = (OwnerPage)Application.OpenForms["OwnerPage"];
                ownersPage.dgvOwners.DataSource = _OwnerRepos.List();
                foreach (Control t in Controls)
                {
                    if (t is TextBox)
                    {
                        t.Enabled = false;
                    }
                }
            }
        }
        /// <summary>
        /// Cancels editing of owner details and resets fields to original values
        /// before any changes made
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClick(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? " +
               "All changes will be lost";
            string warning = "Warning";
            DialogResult dialogResult = MessageBox.Show(message, warning,
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnEdit.Visible = true;
                btnCancel.Visible = false;
                btnSave.Visible = false;
                dtpDOB.Enabled = false;
                btnSelectAddress.Enabled = false;
                foreach (Control t in Controls)
                {
                    if (t is TextBox)
                    {
                        t.Enabled = false;
                    }
                }
                txtFirstName.Text = _Owner.FirstName;
                txtSurname.Text = _Owner.LastName;
                dtpDOB.Value = _Owner.DateOfBirth;
                txtAddress.Text = _Owner.Line1 + " " + _Owner.City + " "
                    + _Owner.Country + " " + _Owner.Postcode;
            }
        }
        /// <summary>
        /// Shows grid of cars belonging to the specific owner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowCarsClick(object sender, EventArgs e)
        {
            btnHideCars.Visible = true;
            btnShowCars.Visible = false;
            dgvCars.DataSource = _OwnerRepos.FindCar(_Owner.OwnerId);
        }
        /// <summary>
        /// Hides all the cars in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideCarsClick(object sender, EventArgs e)
        {
            btnHideCars.Visible = false;
            btnShowCars.Visible = true;
            dgvCars.DataSource = null;
        }
        /// <summary>
        /// allows user to edit car details 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarGridClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var carDetailPage = new CarDetailsPage();
                var regNumber = dgvCars.Rows[e.RowIndex].Cells[2].Value;
                var modelName = dgvCars.Rows[e.RowIndex].Cells[3].Value;
                var makeName = dgvCars.Rows[e.RowIndex].Cells[4].Value;
                var colourName = dgvCars.Rows[e.RowIndex].Cells[5].Value;
                var regDate = dgvCars.Rows[e.RowIndex].Cells[6].Value;
                var ownerFirstName = dgvCars.Rows[e.RowIndex].Cells[7].Value;
                var ownerSurname = dgvCars.Rows[e.RowIndex].Cells[8].Value;
                var ownerID = dgvCars.Rows[e.RowIndex].Cells[1].Value;
                var carID = dgvCars.Rows[e.RowIndex].Cells[0].Value;
                carDetailPage.txtRegNumber.Text = regNumber.ToString();
                carDetailPage.cmbMake.Text = makeName.ToString();
                carDetailPage.cmbModel.Text = modelName.ToString();
                carDetailPage.cmbColour.Text = colourName.ToString();
                carDetailPage.txtFirstName.Text = ownerFirstName.ToString();
                carDetailPage.txtSurname.Text = ownerSurname.ToString();
                carDetailPage.dtpRegDate.Text = regDate.ToString();
                carDetailPage._Car.OwnerID = (int)ownerID;
                carDetailPage._Car.CarID = (int)carID;
                carDetailPage.Show();
            }
        }
        /// <summary>
        /// Allows user to add car for that owner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCarClick(object sender, EventArgs e)
        {
            _Owner.FirstName = txtFirstName.Text;
            _Owner.LastName = txtSurname.Text;
            var carDetailPage = new CarDetailsPage();
            carDetailPage.btnShowSightings.Visible = false;
            carDetailPage.btnEdit.Visible = false;
            carDetailPage.btnSaveEdit.Visible = false;
            carDetailPage.btnCancelEdit.Visible = false;
            carDetailPage.btnCancelAdd.Visible = true;
            carDetailPage.btnAdd.Visible = false;
            carDetailPage.btnAddOwnerCar.Visible = true;
            carDetailPage.txtRegNumber.Enabled = true;
            carDetailPage.cmbModel.Enabled = true;
            carDetailPage.txtFirstName.Enabled = true;
            carDetailPage.cmbColour.Enabled = true;
            carDetailPage.dtpRegDate.Enabled = true;
            carDetailPage.cmbMake.Enabled = true;
            carDetailPage.btnSelectOwner.Enabled = false;
            carDetailPage.txtSurname.Enabled = true;
            carDetailPage.txtFirstName.Text = _Owner.FirstName;
            carDetailPage.txtSurname.Text = _Owner.LastName;
            carDetailPage._Car.OwnerID = this._Owner.OwnerId;
            carDetailPage.Show();
        }
    }
}
