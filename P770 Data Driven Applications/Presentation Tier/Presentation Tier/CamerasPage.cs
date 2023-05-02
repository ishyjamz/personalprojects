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

namespace Presentation_Tier
{
    /// <summary>
    /// Contains logic for filtering camera datagridview and all intereactions with it
    /// allows user to open camera details page 
    /// </summary>
    public partial class CamerasPage : Form
    {
        /// <summary>
        /// New instance of camera repos so user can retrieve cameras from database
        /// </summary>
        public CameraRepository _CameraRepos = new CameraRepository(); 
        public CamerasPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sends user back to home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHome_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
        /// <summary>
        /// Filters camera list to search for specific cameras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CameraSearch(object sender, EventArgs e)
        {
            if (txtLongFrom.Text != string.Empty || txtLongTo.Text != string.Empty 
                || txtLatFrom.Text != string.Empty || txtLatTo.Text != string.Empty)
            {
                dgvCameras.DataSource = _CameraRepos.CameraSearch(txtRoadName.Text,
                txtRoadNumber.Text, decimal.Parse(txtLongFrom.Text), decimal.Parse(txtLongTo.Text),
                decimal.Parse(txtLatFrom.Text), decimal.Parse(txtLatTo.Text));
            }
            else
            {
                txtLongFrom.Text = "-1000";
                txtLatFrom.Text = "-1000";
                txtLongTo.Text = "1000";
                txtLatTo.Text = "1000";
                dgvCameras.DataSource = _CameraRepos.CameraSearch(txtRoadName.Text,
                txtRoadNumber.Text, decimal.Parse(txtLongFrom.Text), decimal.Parse(txtLongTo.Text),
                decimal.Parse(txtLatFrom.Text), decimal.Parse(txtLatTo.Text));
            }
        }

        /// <summary>
        /// Hides all results in data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideResultsClick(object sender, EventArgs e)
        {
            dgvCameras.DataSource = null;
            btnHideResults.Visible = false; 
        }

        /// <summary>
        /// Clears all filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearClick(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
        /// <summary>
        /// Opens the edit camera page so camera can be added to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCameraClick(object sender, EventArgs e)
        {
            CameraDetailsPage camDetails = new CameraDetailsPage();
            camDetails.cmbCameraType.Enabled = true;
            camDetails.btnSelectAddress.Enabled = true;
            camDetails.btnSave.Visible = false;
            camDetails.btnCancel.Visible = false;
            camDetails.btnEdit.Visible = false;
            camDetails.btnAdd.Visible = true;
            camDetails.btnClear.Visible = true;
            camDetails.dgvSightings.Visible = false;
            camDetails.btnShowSightings.Visible = false;
            foreach (Control c in camDetails.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }
            }
            camDetails.txtSpeedThreshold.Enabled = false;
            camDetails.txtTimeThreshold.Enabled = false;
            camDetails.ShowDialog();
        }
        /// <summary>
        /// Allows user to access camera details for camera they click on in the 
        /// data grid row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CameraRowClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex != -1)
            {
                CameraDetailsPage camDetails = new CameraDetailsPage();
                var cameraId = dgvCameras.Rows[e.RowIndex].Cells[0].Value;
                var addressId = dgvCameras.Rows[e.RowIndex].Cells[1].Value;
                var roadName = dgvCameras.Rows[e.RowIndex].Cells[2].Value;
                var roadNumber = dgvCameras.Rows[e.RowIndex].Cells[3].Value;
                var longitude = dgvCameras.Rows[e.RowIndex].Cells[4].Value;
                var latitude = dgvCameras.Rows[e.RowIndex].Cells[5].Value;
                var speedThreshold = dgvCameras.Rows[e.RowIndex].Cells[6].Value;
                var timeThreshold = dgvCameras.Rows[e.RowIndex].Cells[7].Value;
                var line1 = dgvCameras.Rows[e.RowIndex].Cells[8].Value;

                camDetails.txtRoadName.Text = roadName.ToString();
                if (roadNumber != null)
                {
                    camDetails.txtRoadNumber.Text = roadNumber.ToString();
                }
                camDetails.txtLongitude.Text = longitude.ToString();
                camDetails.txtLatitude.Text = latitude.ToString();
                if (line1 != null)
                {
                    camDetails.txtAddress.Text = line1.ToString();
                }
                if (speedThreshold!= null)
                {
                    camDetails.txtSpeedThreshold.Text = speedThreshold.ToString();
                    camDetails.cmbCameraType.SelectedIndex= 1;

                }
                if (timeThreshold!= null)
                {
                    camDetails.txtTimeThreshold.Text = timeThreshold.ToString();
                    camDetails.cmbCameraType.SelectedIndex = 2;
                }
                if(speedThreshold == null && timeThreshold == null)
                {
                    camDetails.cmbCameraType.SelectedIndex = 3;
                }
                camDetails._Camera.CameraId = (int)cameraId;
                if (addressId != null)
                {
                    camDetails._Camera.AddressId = (int)addressId;
                }
                camDetails.txtSpeedThreshold.Enabled = false;
                camDetails.txtTimeThreshold.Enabled = false;
                camDetails.ShowDialog();
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
