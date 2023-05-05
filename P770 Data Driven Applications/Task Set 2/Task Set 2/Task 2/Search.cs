using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Search : Form
    {
        private string _ConnectionString = ConfigurationManager
           .ConnectionStrings["DDAConnection"].ConnectionString;
        public Search()
        {
            InitializeComponent();
            dataEmployee.AutoGenerateColumns = false;
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty && txtSurname.Text == string.Empty && txtPostcode.Text == string.Empty)
            {
                string message = "Nothing was entered into the search fields";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                SearchProcedure();
            }
        }
        private void SearchProcedure()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Employee_SEARCH", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (txtFirstName.Text != string.Empty)
                {
                    cmd.Parameters.Add(new SqlParameter("@FirstName", txtFirstName.Text));
                }
                if (txtSurname.Text != string.Empty)
                {
                    cmd.Parameters.Add(new SqlParameter("@Surname", txtSurname.Text));
                }
                if (txtPostcode.Text != string.Empty)
                {
                    cmd.Parameters.Add(new SqlParameter("@Postcode", txtPostcode.Text));
                }

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var employee = new List<Employee>();
                    while (reader.Read())
                    {
                        employee.Add(EmployeeFromRecord(reader));
                    }
                    dataEmployee.DataSource = employee;          
                }
            }
        }
        private static Employee EmployeeFromRecord(
           IDataRecord record)
        {
            return new Employee
            {
                EmployeeID = (int)record["EmployeeID"],
                FirstName = (string)record["FirstName"],
                Surname = (string)record["Surname"],
                Address = (string)record[3],
                Postcode = (string)record["Postcode"],
                Salary = (decimal)record["Salary"],
                StartDate = (DateTime)record["StartDate"]
            };
        }

        public void GETEmployee(int employeeID)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Employee_READ", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", employeeID ));
                

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    var employee = new List<Employee>();
                    while (reader.Read())
                    {
                        employee.Add(EmployeeFromRecord(reader));
                    }
                    dataEmployee.DataSource = employee;
                }
            }
        }

        private void DataEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var employeeID = dataEmployee.Rows[e.RowIndex].Cells[0].Value;
                var firstName = dataEmployee.Rows[e.RowIndex].Cells[1].Value;
                var surname = dataEmployee.Rows[e.RowIndex].Cells[2].Value;
                var address = dataEmployee.Rows[e.RowIndex].Cells[3].Value;
                var postcode = dataEmployee.Rows[e.RowIndex].Cells[4].Value;
                var salary = dataEmployee.Rows[e.RowIndex].Cells[5].Value;
                var startDate = dataEmployee.Rows[e.RowIndex].Cells[6].Value;
                GETEmployee((int)employeeID);
                var originalForm = (Form1)Application.OpenForms["Form1"];
                originalForm.txtEmployeeID.Text = employeeID.ToString();
                originalForm.txtFirstName.Text = firstName.ToString(); 
                originalForm.txtSurname.Text = surname.ToString();
                originalForm.txtAddress.Text = address.ToString();
                originalForm.txtPostcode.Text = postcode.ToString();
                originalForm.txtSalary.Text =  salary.ToString();
                originalForm.txtStartDate.Text = startDate.ToString();
                originalForm.btnUpdate.Enabled = true;
                originalForm.btnDelete.Enabled = true;
                this.Close();
            }
        }
    }
}
