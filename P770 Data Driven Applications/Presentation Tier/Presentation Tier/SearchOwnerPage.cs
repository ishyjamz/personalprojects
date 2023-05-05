using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Library;
using BusinessLayer;

namespace Presentation_Tier
{
    public partial class SearchOwnerPage : Form
    {
        private OwnerRepository _OwnerRepos = new OwnerRepository();

        public SearchOwnerPage()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }
        /// <summary>
        /// Shows all owners matching criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchOwner_Click_1(object sender, EventArgs e)
        {
            dgvOwner.DataSource = _OwnerRepos.SearchOwner(txtOwnerFirstName.Text,
                txtOwnerSurname.Text, txtAddressLine1.Text,txtCity.Text,
                txtCountry.Text, txtPostcode.Text);
        }
        /// <summary>
        /// Closes page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clears search criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control t in Controls)
            {
                if (t is TextBox)
                {
                    t.Text = string.Empty;
                }
            }
        }
        /// <summary>
        /// Adds whichever owner who was clicked to car details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvOwner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var carDetailPage = (CarDetailsPage)Application.OpenForms["CarDetailsPage"];
                var firstName = dgvOwner.Rows[e.RowIndex].Cells[0].Value;
                var surname = dgvOwner.Rows[e.RowIndex].Cells[1].Value;
                var ownerID = dgvOwner.Rows[e.RowIndex].Cells[6].Value;
                carDetailPage.txtFirstName.Text = firstName.ToString();
                carDetailPage.txtSurname.Text = surname.ToString();
                carDetailPage._Car.OwnerID = (int)ownerID;
                this.Close();
            }
        }
    }
}
