using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Model_Library;

namespace Presentation_Tier
{
    public partial class OwnerPage : Form
    {
        public OwnerRepository _OwnerRepos = new OwnerRepository();
        public CarPresentation _Car = new CarPresentation();
        public OwnerPage()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
        /// <summary>
        /// Populates data grid with all owners based on user's search criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvOwners.DataSource = _OwnerRepos.SearchOwner(txtFirstName.Text,
                            txtSurname.Text, txtAddressLine1.Text, txtCity.Text,
                            txtCountry.Text, txtPostcode.Text);
        }
        /// <summary>
        /// clears all the filters and unpopulates the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            foreach (Control t in Controls)
            {
                if (t is TextBox)
                {
                    t.Text = string.Empty;
                }
            }
            dgvOwners.DataSource = null;
        }
        /// <summary>
        /// opens page to add new owner to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddOwner_Click(object sender, EventArgs e)
        {
            OwnerDetailsPage ownerDetailsPage = new OwnerDetailsPage();
            ownerDetailsPage.btnEdit.Visible = false;
            ownerDetailsPage.txtFirstName.Enabled = true;
            ownerDetailsPage.txtSurname.Enabled = true;
            ownerDetailsPage.txtAddress.Enabled = true;
            ownerDetailsPage.dtpDOB.Enabled = true;
            ownerDetailsPage.btnAdd.Visible = true;
            ownerDetailsPage.btnCancelAdd.Visible= true;
            ownerDetailsPage.btnSelectAddress.Enabled= true;
            ownerDetailsPage.dgvCars.Visible = false;
            ownerDetailsPage.btnShowCars.Visible = false;
            ownerDetailsPage.Show();
        }
        /// <summary>
        /// allows user to access page with the clicked owner's details 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OwnerDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                OwnerDetailsPage ownerDetailsPage = new OwnerDetailsPage();
                var ownerId = dgvOwners.Rows[e.RowIndex].Cells[0].Value;
                var addressId = dgvOwners.Rows[e.RowIndex].Cells[1].Value;
                var firstName = dgvOwners.Rows[e.RowIndex].Cells[2].Value;
                var surname = dgvOwners.Rows[e.RowIndex].Cells[3].Value;
                var dob = dgvOwners.Rows[e.RowIndex].Cells[4].Value;
                var line1 = dgvOwners.Rows[e.RowIndex].Cells[5].Value;
                var city = dgvOwners.Rows[e.RowIndex].Cells[6].Value;
                var country = dgvOwners.Rows[e.RowIndex].Cells[7].Value;
                var postcode = dgvOwners.Rows[e.RowIndex].Cells[8].Value;
                var rowVersion = dgvOwners.Rows[e.RowIndex].Cells[9].Value;
                ownerDetailsPage.txtFirstName.Text = firstName.ToString();
                ownerDetailsPage.txtSurname.Text = surname.ToString();
                ownerDetailsPage.dtpDOB.Value = (DateTime)dob;
                ownerDetailsPage.txtAddress.Text = line1.ToString() + " " + city.ToString() + 
                    " " + country.ToString() + " " + postcode.ToString();
                ownerDetailsPage._Owner.OwnerId = (int)ownerId;
                ownerDetailsPage._Owner.AddressId= (int)addressId;
                ownerDetailsPage._Owner.RowVersion = (byte[])rowVersion;
                ownerDetailsPage.btnAddCar.Visible = true;
                ownerDetailsPage.Show();
            }
            else
            {
                string message = "Cannot click that part of the data grid. Make sure " +
                "you click on a row with pre-existing data";
                string error = "Error";
                MessageBox.Show(message, error);
            }
        }
    }
}
