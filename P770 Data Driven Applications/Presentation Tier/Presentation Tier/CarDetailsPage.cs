using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Library;
using BusinessLayer;
using Entity_Library;
using System.Data.Entity.Validation;

namespace Presentation_Tier
{
    /// <summary>
    /// Contains logic for adding new car to database and updating car details
    /// </summary>
    public partial class CarDetailsPage : Form
    {
        public CarRepository _CarRepos = new CarRepository();
        public CarPresentation _Car = new CarPresentation();
        public SightingRepository _SightingRepos = new SightingRepository();

        public CarDetailsPage()
        {
            InitializeComponent();
            PopulateMakeList();
            PopulateColourList();
            PopulateModelList();
        }

        /// <summary>
        /// Adds an empty string datapoint to list of car makes
        /// </summary>
        private void PopulateMakeList()
        {
            List<MakePresentation> list = new List<MakePresentation>();
            MakePresentation make = new MakePresentation();
            make.MakeID = -1;
            make.Name = " ";
            list.Add(make);
            var makeList = _CarRepos.MakeList();
            foreach (var m in makeList)
            {
                list.Add(m);
            }
            cmbMake.DataSource = list;
        }
        /// <summary>
        /// Adds an empty string datapoint to list of car models       
        /// </summary>
        private void PopulateModelList()
        {
            List<ModelPresentation> list = new List<ModelPresentation>();
            ModelPresentation model = new ModelPresentation();
            model.ModelId = -1;
            model.Name = " ";
            list.Add(model);
            var modelList = _CarRepos.ModelList();
            foreach (var m in modelList)
            {
                list.Add(m);
            }
            this.cmbModel.DataSource = list;
        }
        /// <summary>
        /// Adds an empty string datapoint to list of car colours      
        /// </summary>
        private void PopulateColourList()
        {
            List<ColourPresentation> list = new List<ColourPresentation>();
            ColourPresentation colour = new ColourPresentation();
            colour.ColourId = -1;
            colour.Name = " ";
            list.Add(colour);
            var colourList = _CarRepos.ColourList();
            foreach (var m in colourList)
            {
                list.Add(m);
            }
            cmbColour.DataSource = list;
        }
        /// <summary>
        /// Adds an empty string datapoint to list of car models for each make  
        /// </summary>
        private void PopulateFilteredModelList()
        {
            List<ModelPresentation> list = new List<ModelPresentation>();
            ModelPresentation model = new ModelPresentation();
            model.ModelId = -1;
            model.Name = null;
            list.Add(model);

            var modelList = _CarRepos.FilteredModelList((int)cmbMake.SelectedValue);
            foreach (var m in modelList)
            {
                list.Add(m);
            }
            cmbModel.DataSource = list;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Updates car details to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbModel.SelectedValue != -1 && txtRegNumber.Text != string.Empty
                && dtpRegDate.Value <= DateTime.Today && (int)cmbColour.SelectedValue != -1)
                {
                    _Car.ModelID = (int)cmbModel.SelectedValue;
                    _Car.RegNumber = txtRegNumber.Text;
                    _Car.RegDate = dtpRegDate.Value;
                    _Car.ColourID = (int)cmbColour.SelectedValue;
                    _CarRepos.UpdateCarDetails(_Car);
                    string message = "Car details have been updated successfully";
                    string title = "Message";
                    MessageBox.Show(message, title);
                    btnSaveEdit.Visible = false;
                    btnCancelEdit.Visible = false;
                    btnEdit.Visible = true;
                    dtpRegDate.Enabled = false;
                    btnSelectOwner.Enabled = false;
                    foreach (Control t in Controls)
                    {
                        if (t is TextBox)
                        {
                            t.Enabled = false;
                        }
                        else if (t is ComboBox)
                        {
                            t.Enabled = false;
                        }
                    }
                }
                else
                {
                    string message = "Incorrect input into one or more of the fields. " +
                        "Please check again";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
            }
            catch(DbEntityValidationException)
            {
                string message = "Incorrect input into reg number field";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }
        /// <summary>
        /// Allows user to edit car details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnCancelEdit.Visible = true;
            btnEdit.Visible = false;
            btnSaveEdit.Visible = true;
            cmbColour.Enabled = true;
            txtFirstName.Enabled = true;
            txtRegNumber.Enabled = true;
            cmbModel.Enabled = true;
            cmbMake.Enabled = true;
            btnSelectOwner.Enabled = true;
            dtpRegDate.Enabled = true;
            txtSurname.Enabled = true;
            _Car.RegNumber = txtRegNumber.Text;
            _Car.RegDate = dtpRegDate.Value;
            _Car.ColourName = cmbColour.Text;
            _Car.ModelName = cmbModel.Text;
            _Car.MakeName = cmbMake.Text;
            _Car.OwnerFirstName = txtFirstName.Text;
            _Car.OwnerSurname = txtSurname.Text;
        }
        /// <summary>
        /// Opens page to allow user to select owner for their car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectOwner_Click(object sender, EventArgs e)
        {
            SearchOwnerPage search = new SearchOwnerPage();
            search.Show();
        }
        /// <summary>
        /// Filters down model dropdown so only models for that make show up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFilteredModelList();
        }
        /// <summary>
        /// Resets values before any changes made 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? " +
               "All changes will be lost";
            string warning = "Warning";
            DialogResult dialogResult = MessageBox.Show(message, warning,
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnEdit.Visible = true;
                btnCancelEdit.Visible = false;
                btnSaveEdit.Visible = false;
                dtpRegDate.Enabled = false;
                btnSelectOwner.Enabled = false;
                foreach (Control t in Controls)
                {
                    if (t is TextBox)
                    {
                        t.Enabled = false;
                    }
                    else if (t is ComboBox)
                    {
                        t.Enabled = false;
                    }
                }
                txtRegNumber.Text = _Car.RegNumber;
                txtFirstName.Text = _Car.OwnerFirstName;
                txtSurname.Text = _Car.OwnerSurname;
                cmbColour.Text = _Car.ColourName;
                cmbMake.Text = _Car.MakeName;
                cmbModel.Text = _Car.ModelName;
                dtpRegDate.Text = _Car.RegDate.ToString();
            }
        }
        /// <summary>
        /// Clears all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelAdd_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel? " +
               "All changes will be lost";
            string warning = "Warning";
            DialogResult dialogResult = MessageBox.Show(message, warning,
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dtpRegDate.Text = default(string);
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
        /// Adds new car to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveAdd_Click(object sender, EventArgs e)
        {
            _Car.RegNumber = txtRegNumber.Text;
            _Car.RegDate = dtpRegDate.Value;
            _Car.ColourID = (int)cmbColour.SelectedValue;
            _Car.ModelID = (int)cmbModel.SelectedValue;
            var carsPage = (CarsPage)Application.OpenForms["CarsPage"];
            try
            {
                if (txtRegNumber.Text != string.Empty && dtpRegDate.Value <= DateTime.Today 
                    && (int)cmbColour.SelectedValue != -1 && (int)cmbModel.SelectedValue != -1)
                {
                    _CarRepos.AddNewCar(_Car);
                    carsPage.dgvCars.DataSource = _CarRepos.List();
                    string message = "New car added successfully to the database";
                    string title = "Message";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message1 = "Required Fields not filled out";
                    string error = "Error";
                    MessageBox.Show(message1, error);
                }
            }
            catch (DbEntityValidationException)
            {
                string message1 = "Incorrect input for reg number";
                string error = "Error";
                MessageBox.Show(message1, error);
            }
        }
        /// <summary>
        /// Allows user to see all sightings for that particular car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowSightings_Click(object sender, EventArgs e)
        {
            btnHideSightings.Visible = true;
            btnShowSightings.Visible = false;
            dgvSightings.DataSource = _SightingRepos.FindSighting(_Car.CarID);
            dgvSightings.Visible = true;
        }
        /// <summary>
        /// Hides the sightings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHideSightings_Click(object sender, EventArgs e)
        {
            btnHideSightings.Visible = false;
            btnShowSightings.Visible = true;
            dgvSightings.Visible = false;
        }
        /// <summary>
        /// Allows user to add car for a particular owner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOwnerCar(object sender, EventArgs e)
        {
             _Car.RegNumber = txtRegNumber.Text;
            _Car.RegDate = dtpRegDate.Value;
            _Car.ColourID = (int)cmbColour.SelectedValue;
            _Car.ModelID = (int)cmbModel.SelectedValue;
            try
            {
                if (txtRegNumber.Text != string.Empty && dtpRegDate.Value <= DateTime.Now 
                    && (int)cmbColour.SelectedValue != -1 && (int)cmbModel.SelectedValue != -1)
                {
                    _CarRepos.AddNewCar(_Car);
                    string message = "New car added successfully to the database";
                    string title = "Message";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message1 = "Required Fields not filled out";
                    string error = "Error";
                    MessageBox.Show(message1, error);
                }
            }
            catch (DbEntityValidationException)
            {
                string message1 = "Incorrect input for reg number";
                string error = "Error";
                MessageBox.Show(message1, error);
            }
        }
    }
}
