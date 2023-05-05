using EnterpriseLibrary;
using EntityFrameworkRepo;
using Interfaces;
using Models;
using SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataAccessTest
{
    /// <summary>
    /// Initialises a new instance of the <see cref="DataAccessTest"/> class.
    /// Form used to demonstrate various approaches to data access.
    /// </summary>
    public partial class DataAccessTest : Form
    {
        /// <summary>
        /// The Car repository currently being used by the form.
        /// </summary>
        private ICarRepository _Repository = null;

        /// <summary>
        /// Initialises a new instance of the <see cref="DataAccessTest"/> class.
        /// </summary>
        public DataAccessTest()
        {
            this.InitializeComponent();
            this.dgCars.AutoGenerateColumns = false;
            this.PopulateRepositoryDropDown();
        }

        /// <summary>
        /// Populates a new instance of the <see cref="Car"/> class with
        /// information from the form.
        /// </summary>
        private Car PopulateNewCar()
        {
            return new Car
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                RegNumber = txtRegNumber.Text,
                RegistrationDate = DateTime.Now
            };
        }

        /// <summary>
        /// Inserts a Car record into the database using the data provided by
        /// the user and the currently selected data access approach.
        /// </summary>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (this.ValidateRepositorySelected())
            {
                this._Repository.Insert(this.PopulateNewCar());
            }
        }

        /// <summary>
        /// Clears the contents of the cars grid.
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
             this.dgCars.DataSource = null;
        }

        /// <summary>
        /// Lists all Car records from the database in the cars grid using the
        /// currently selected data access approach.
        /// </summary>
        private void BtnList_Click(object sender, EventArgs e)
        {
            if (this.ValidateRepositorySelected())
            {
                this.dgCars.DataSource = this._Repository.List();
            }
        }

        /// <summary>
        /// Populates the repository dropdown list with the set of available
        /// repositories.
        /// </summary>
        private void PopulateRepositoryDropDown()
        {
            var options = new Dictionary<string, ICarRepository>()
            {
                { "[Please Select]", null },
                { "Sql Client Classes", new SqlClientCarRepository() },
                { "Enterprise Library", new EnterpriseLibraryCarRepository() },
                { "Entity Framework", new EntityFrameworkCarRepository() }
            };

            cmbRepository.DataSource = options.ToList();
            cmbRepository.DisplayMember = "Key"; 
            cmbRepository.ValueMember = "Value";
            
            cmbRepository.SelectedIndex = 0;

            // We can improve this code in C# 6.0 thanks to nameof!
            // We no longer need hard coded strings, we can make the Display member and Value member mapping obvious
            // cmbRepository.DisplayMember = nameof(KeyValuePair<string,IRepository>.Key);
            // cmbRepository.ValueMember = nameof(KeyValuePair<string,IRepository>.Value);
        }

        /// <summary>
        /// Validates that a repository has been selected and initialised.
        /// Displays an error message if not.
        /// </summary>
        /// <returns>True if a repository is selected, false otherwise.</returns>
        private bool ValidateRepositorySelected()
        {
            if (this._Repository == null)
            {
                MessageBox.Show(
                    "Please choose a repository",
                    "No repository loaded.",
                    MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Creates a new instance of the relevant repository when the user
        /// makes a selection in the repository dropdown.
        /// </summary>
        private void CmbRepository_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._Repository = cmbRepository.SelectedValue as ICarRepository;
        }
    }
}
