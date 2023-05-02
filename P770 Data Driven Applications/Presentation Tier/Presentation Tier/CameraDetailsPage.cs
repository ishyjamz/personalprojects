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
    /// <summary>
    /// Contains all methods handling events in camera details page
    /// </summary>
    public partial class CameraDetailsPage : Form
    {
        /// <summary>
        /// Creates new instance of Camera Repository so methods can be called from
        /// business layer
        /// </summary>
        public CameraRepository _CameraRepos = new CameraRepository();
        /// <summary>
        /// Creates new instance of my Camera model so model can be updated
        /// </summary>
        public CameraPresentation _Camera = new CameraPresentation();
        /// <summary>
        /// Creates new instance of Sighting repository so methods can be called
        /// from business layer
        /// </summary>
        public SightingRepository _SightingRepos = new SightingRepository();
        /// <summary>
        /// initialises componenets and presets the camera types combobox
        /// </summary>
        public CameraDetailsPage()
        {
            InitializeComponent();
            string[] cameraTypes = {"Please Select", "Speed Camera", "Traffic Light Camera", "ANPR Camera" };
            cmbCameraType.DataSource = cameraTypes;  
        }

        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Checks if all input into the fields is correct and adds a new camera
        /// to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClick(object sender, EventArgs e)
        {
            if (txtRoadName.Text != string.Empty &&
                txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty 
                && (cmbCameraType.Text == "Speed Camera" || 
                cmbCameraType.Text == "Traffic Light Camera" || 
                cmbCameraType.Text == "ANPR Camera"))
            {
                _Camera.RoadName = txtRoadName.Text;
                _Camera.RoadNumber = txtRoadNumber.Text;
                try
                {
                    _Camera.Latitude = decimal.Parse(txtLatitude.Text);
                }
                catch (FormatException)
                {
                    string message = "Latitude must be a decimal";
                    string warning = "Error";
                    MessageBox.Show(message, warning);
                    txtLatitude.Text = string.Empty;
                }
                try
                {
                    _Camera.Longitude = decimal.Parse(txtLongitude.Text);
                }
                catch
                {
                    string message = "Longitude must be a decimal";
                    string warning = "Error";
                    MessageBox.Show(message, warning);
                    txtLongitude.Text = string.Empty;
                }
                _Camera.CameraType = cmbCameraType.Text;
                if (txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty 
                    && cmbCameraType.Text == "Speed Camera" 
                    && txtSpeedThreshold.Text != string.Empty)
                {
                    try
                    {
                        _Camera.SpeedThreshold = byte.Parse(txtSpeedThreshold.Text);
                    }
                    catch (FormatException)
                    {

                        string message = "Speed threshold must be a number";
                        string warning = "Error";
                        MessageBox.Show(message, warning);
                        txtSpeedThreshold.Text = string.Empty;
                    }
                    if (txtSpeedThreshold.Text != string.Empty)
                    {
                        _CameraRepos.AddNewCamera(_Camera);
                        SuccessMessage();
                    }
                    else
                    {
                        FailMessage();
                    }
                }
                else if (txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty
                    && cmbCameraType.Text == "Traffic Light Camera"
                    && txtTimeThreshold.Text != string.Empty)
                {
                    try
                    {
                        _Camera.TimeThreshold = byte.Parse(txtTimeThreshold.Text);
                    }
                    catch(FormatException)
                    {

                        string message = "Time threshold must be a number";
                        string warning = "Error";
                        MessageBox.Show(message, warning);
                        txtTimeThreshold.Text = string.Empty;
                    }
                    if (txtTimeThreshold.Text != string.Empty)
                    {
                        _CameraRepos.AddNewCamera(_Camera);
                        SuccessMessage();
                    }
                    else
                    {
                        FailMessage();
                    }
                }
                else
                {
                    FailMessage();
                }
            }
            else
            {
                FailMessage();
            }
        }
        /// <summary>
        /// Message pop up when camera added successfully
        /// </summary>
        public void SuccessMessage()
        {
            string message = "Camera successfully added to database";
            string warning = "Message";
            MessageBox.Show(message, warning);
        }
        /// <summary>
        /// Message pop up when camera updated successfully
        /// </summary>
        public void UpdateSuccessMessage()
        {
            string message = "Camera successfully added to database";
            string warning = "Message";
            MessageBox.Show(message, warning);
        }
        /// <summary>
        /// Message for camera not added
        /// </summary>
        public void FailMessage()
        {
            string message = "Camera could not be added to database."
                    + " Please check if all required fields have been" +
                    " completed";
            string warning = "Error";
            MessageBox.Show(message, warning);
        }
        /// <summary>
        /// Message for camera not updated
        /// </summary>
        public void UpdateFailMessage()
        {
            string message = "Camera could not be added to database."
                    + " Please check if all required fields have been" +
                    " completed";
            string warning = "Error";
            MessageBox.Show(message, warning);
        }
        /// <summary>
        /// enables/disables appropriate textboxes depending on which camera
        /// type is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CameraTypeChanged(object sender, EventArgs e)
        {
            if (cmbCameraType.Text == "Speed Camera")
            {
                txtSpeedThreshold.Enabled = true;
                txtTimeThreshold.Enabled = false;
            }
            else if (cmbCameraType.Text == "Traffic Light Camera")
            {
                txtTimeThreshold.Enabled = true;
                txtSpeedThreshold.Enabled = false;
            }
            else
            {
                txtTimeThreshold.Enabled = false;
                txtSpeedThreshold.Enabled = false;
            }
        }
        /// <summary>
        /// Clears all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearClick(object sender, EventArgs e)
        {
            cmbCameraType.SelectedIndex= 0;
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
        /// <summary>
        /// opens search address page where user can select an address from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAddressClick(object sender, EventArgs e)
        {
            SearchAddressPage searchAddress = new SearchAddressPage();
            searchAddress.dgvAddressTable.Visible = true;
            searchAddress.ShowDialog();
        }
        /// <summary>
        /// Allows for camera details to be edited 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClick(object sender, EventArgs e)
        {
            _Camera.Line1 = txtAddress.Text;
            _Camera.Latitude = decimal.Parse(txtLatitude.Text);
            _Camera.RoadNumber = txtRoadNumber.Text;
            _Camera.RoadName = txtRoadName.Text;
            _Camera.Longitude = decimal.Parse(txtLongitude.Text);
            _Camera.CameraType = cmbCameraType.Text;
            if (txtSpeedThreshold.Text != string.Empty)
            {
                _Camera.SpeedThreshold = byte.Parse(txtSpeedThreshold.Text);
            }
            if (txtTimeThreshold.Text != string.Empty)
            {
                _Camera.TimeThreshold = byte.Parse(txtTimeThreshold.Text);
            }
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c != txtSpeedThreshold && c != txtTimeThreshold)
                {
                    c.Enabled = true;
                }
            }
            if (_Camera.CameraType == "Speed Camera")
            {
                txtSpeedThreshold.Enabled = true;   
            }
            if (_Camera.CameraType == "Traffic Light Camera")
            {
                txtTimeThreshold.Enabled = true;
            }
            cmbCameraType.Enabled = false;
            btnSelectAddress.Enabled = true;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
        /// <summary>
        /// Updates camera details and checks if all fields are inputted correctly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveClick(object sender, EventArgs e)
        {
            if (txtRoadName.Text != string.Empty &&
                txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty
                && (cmbCameraType.Text == "Speed Camera" ||
                cmbCameraType.Text == "Traffic Light Camera" ||
                cmbCameraType.Text == "ANPR Camera"))
            {
                _Camera.Line1 = txtAddress.Text;
                _Camera.RoadName = txtRoadName.Text;
                _Camera.RoadNumber = txtRoadNumber.Text;
                try
                {
                    _Camera.Latitude = decimal.Parse(txtLatitude.Text);
                }
                catch (FormatException)
                {
                    string message = "Latitude must be a decimal";
                    string warning = "Error";
                    MessageBox.Show(message, warning);
                    txtLatitude.Text = string.Empty;
                }
                try
                {
                    _Camera.Longitude = decimal.Parse(txtLongitude.Text);
                }
                catch
                {
                    string message = "Longitude must be a decimal";
                    string warning = "Error";
                    MessageBox.Show(message, warning);
                    txtLongitude.Text = string.Empty;
                }
                _Camera.CameraType = cmbCameraType.Text;
                if (txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty
                    && cmbCameraType.Text == "Speed Camera"
                    && txtSpeedThreshold.Text != string.Empty)
                {
                    try
                    {
                        _Camera.SpeedThreshold = byte.Parse(txtSpeedThreshold.Text);
                    }
                    catch (FormatException)
                    {

                        string message = "Speed threshold must be a number";
                        string warning = "Error";
                        MessageBox.Show(message, warning);
                        txtSpeedThreshold.Text = string.Empty;
                    }
                    if (txtSpeedThreshold.Text != string.Empty)
                    {
                        _CameraRepos.UpdateCameraDetails(_Camera);
                        UpdateSuccessMessage();
                        btnEdit.Visible = true;
                        btnSave.Visible = false;
                        btnCancel.Visible = false;
                        foreach (Control c in this.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Enabled = false;
                            }
                        }
                        cmbCameraType.Enabled = false;
                        btnSelectAddress.Enabled = false;
                    }
                    else
                    {
                        UpdateFailMessage();
                    }
                }
                else if (txtLatitude.Text != string.Empty && txtLongitude.Text != string.Empty
                    && cmbCameraType.Text == "Traffic Light Camera"
                    && txtTimeThreshold.Text != string.Empty)
                {
                    try
                    {
                        _Camera.TimeThreshold = byte.Parse(txtTimeThreshold.Text);
                    }
                    catch (FormatException)
                    {

                        string message = "Time threshold must be a number";
                        string warning = "Error";
                        MessageBox.Show(message, warning);
                        txtTimeThreshold.Text = string.Empty;
                    }
                    if (txtTimeThreshold.Text != string.Empty)
                    {
                        _CameraRepos.UpdateCameraDetails(_Camera);
                        UpdateSuccessMessage();
                        btnEdit.Visible = true;
                        btnSave.Visible = false;
                        btnCancel.Visible = false;
                        foreach (Control c in this.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Enabled = false;
                            }
                        }
                        cmbCameraType.Enabled = false;
                        btnSelectAddress.Enabled = false;
                    }
                    else
                    {
                        UpdateFailMessage();
                    }
                }
                else
                {
                    UpdateFailMessage();
                }
            }
            else
            {
                UpdateFailMessage();
            }
        }
        /// <summary>
        /// Resets all fields 
        /// </summary>
        private void Cancel()
        {
            txtAddress.Text = _Camera.Line1;
            txtLatitude.Text = _Camera.Latitude.ToString();
            txtRoadNumber.Text = _Camera.RoadNumber;
            txtRoadName.Text = _Camera.RoadName;
            txtLongitude.Text = _Camera.Longitude.ToString();
            cmbCameraType.Text = _Camera.CameraType;
            txtSpeedThreshold.Text = _Camera.SpeedThreshold.ToString();
            txtTimeThreshold.Text = _Camera.TimeThreshold.ToString();
        }
        /// <summary>
        /// makes appropriate controls disabled again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClick(object sender, EventArgs e)
        {
            Cancel();
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }
            }
            cmbCameraType.Enabled = false;
            btnSelectAddress.Enabled = false;
        }
        /// <summary>
        /// Displays all camera sightings for the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSightingsClick(object sender, EventArgs e)
        {
            dgvSightings.DataSource = _SightingRepos.FindCameraSighting(_Camera.CameraId);
            btnShowSightings.Visible = false;
            btnHideSightings.Visible = true;
        }
        /// <summary>
        /// Hides the sightings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideSightingsClick(object sender, EventArgs e)
        {
            dgvSightings.DataSource = null;
            btnShowSightings.Visible = true;
            btnHideSightings.Visible = false;
        }
    }
}
