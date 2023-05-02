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
    public partial class SearchAddressPage : Form
    {
        public AddressRepository _AddressRepos = new AddressRepository();  
        public SearchAddressPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// populates address data grid with addresses matching criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchAddressClick(object sender, EventArgs e)
        {
            dgvAddress.DataSource = _AddressRepos.SearchAddress(txtLine1.Text,
              txtCity.Text, txtCountry.Text, txtPostcode.Text);
            dgvAddressTable.DataSource = _AddressRepos.SearchAddress(txtLine1.Text,
              txtCity.Text, txtCountry.Text, txtPostcode.Text);
        }
        /// <summary>
        /// Closes page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Adds that address to owner details 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressGridClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var ownerDetailPage = (OwnerDetailsPage)Application.OpenForms["OwnerDetailsPage"];
                var addressId = dgvAddress.Rows[e.RowIndex].Cells[0].Value;
                var line1 = dgvAddress.Rows[e.RowIndex].Cells[1].Value;
                var city = dgvAddress.Rows[e.RowIndex].Cells[4].Value;
                var country = dgvAddress.Rows[e.RowIndex].Cells[6].Value;
                var postcode = dgvAddress.Rows[e.RowIndex].Cells[7].Value;
                ownerDetailPage.txtAddress.Text = line1.ToString() + " "
                    + city.ToString() + " " + country.ToString() + " " 
                    + postcode.ToString();
                ownerDetailPage._Owner.AddressId = (int)addressId;
                this.Close();
            }
            else
            {
                string message1 = "Cannot click on that part of the grid";
                string error = "Error";
                MessageBox.Show(message1, error);
            }
        }
        /// <summary>
        /// Adds the address to camera details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressTableClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var cameraDetailsPage = (CameraDetailsPage)Application.OpenForms["CameraDetailsPage"];
                var addressId = dgvAddress.Rows[e.RowIndex].Cells[0].Value;
                var line1 = dgvAddress.Rows[e.RowIndex].Cells[1].Value;
                cameraDetailsPage.txtAddress.Text = line1.ToString();
                cameraDetailsPage._Camera.AddressId = (int)addressId;
            }
            this.Close();
        }
    }
}
