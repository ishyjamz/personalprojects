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
using Entity_Library;
using Model_Library;

namespace Presentation_Tier
{
    public partial class CarsPage : Form
    {
        public CarPresentation Car { get; set; }
        private CarRepository _CarRepos = new CarRepository();
        public CarsPage()
        {
            InitializeComponent();
            PopulateMakeList();
            PopulateColourList();
            PopulateModelList();
        }

        /// <summary>
        /// Adds an empty string datapoint to list of car makes, so user does 
        /// not have to search by car make
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
        /// Adds an empty string datapoint to list of car models, so user does 
        /// not have to search by car make       
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
        /// Adds an empty string datapoint to list of car colours, so user does 
        /// not have to search by car colour       
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
        /// Opens details for car which user clicks on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex != -1)
            {
                var carDetailPage = new CarDetailsPage();
                var regNumber = dgvCars.Rows[e.RowIndex].Cells[0].Value;
                var modelName = dgvCars.Rows[e.RowIndex].Cells[1].Value;
                var makeName = dgvCars.Rows[e.RowIndex].Cells[2].Value;
                var colourName = dgvCars.Rows[e.RowIndex].Cells[3].Value;
                var regDate = dgvCars.Rows[e.RowIndex].Cells[4].Value;
                var ownerFirstName = dgvCars.Rows[e.RowIndex].Cells[5].Value;
                var ownerSurname = dgvCars.Rows[e.RowIndex].Cells[6].Value;
                var ownerID = dgvCars.Rows[e.RowIndex].Cells[7].Value;
                var carID = dgvCars.Rows[e.RowIndex].Cells[8].Value;
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
            else
            {
                DGErrorMessage();
            }
        }
        /// <summary>
        /// Error message for when user clicks on the top of the column in data grid
        /// </summary>
        public void DGErrorMessage()
        {
            string message = "Cannot click that part of the data grid. Make sure " +
                "you click on a row with pre-existing data";
            string error = "Error";
            MessageBox.Show(message, error);
        }
        /// <summary>
        /// Adds empty string data so user does not have to search by model
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
        /// <summary>
        /// Adds car to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            var carDetailPage = new CarDetailsPage();
            carDetailPage.btnShowSightings.Visible = false;
            carDetailPage.btnEdit.Visible = false;
            carDetailPage.btnSaveEdit.Visible = false;
            carDetailPage.btnCancelEdit.Visible = false;
            carDetailPage.btnCancelAdd.Visible = true;
            carDetailPage.btnAdd.Visible = true;
            carDetailPage.txtRegNumber.Enabled = true;
            carDetailPage.cmbModel.Enabled = true;
            carDetailPage.txtFirstName.Enabled = true;
            carDetailPage.cmbColour.Enabled = true;
            carDetailPage.dtpRegDate.Enabled = true;
            carDetailPage.cmbMake.Enabled = true;
            carDetailPage.btnSelectOwner.Enabled = true;
            carDetailPage.txtSurname.Enabled = true;
            carDetailPage.Show();

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
        /// Filters down car list based on user search criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            dgvCars.DataSource = _CarRepos.Filter(txtRegNumber.Text, cmbModel.Text,
                cmbMake.Text, cmbColour.Text, txtFirstName.Text, txtSurname.Text);
        }
        /// <summary>
        /// Resets all search criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control textBox in this.Controls)
            {
                if (textBox is TextBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            foreach (Control combo in this.Controls)
            {
                if (combo is ComboBox)
                {
                    combo.Text = string.Empty;
                }
            }
            dgvCars.DataSource = null;
        }
        /// <summary>
        /// Filters model dropdown to only show models belonging to the selected make
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFilteredModelList();
        }
    }
}
