using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private string _ConnectionString = ConfigurationManager
            .ConnectionStrings["DDAConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtSurname.Text == string.Empty
                || txtAddress.Text == string.Empty ||
                txtPostcode.Text == string.Empty ||
                txtSalary.Text == string.Empty || txtStartDate.Text == string.Empty)
            {
                string message = "You must fill out all fields";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else if (decimal.Parse(txtSalary.Text) > 9999999)
            {
                string message = "Salary cannot be above £9,999,999";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                Create();
                createButton.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void UpdateProcedure()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Employee_UPDATE", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("EmployeeID", SqlDbType.Int).Value = txtEmployeeID.Text;
                cmd.Parameters.Add("FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("Surname", SqlDbType.VarChar).Value = txtSurname.Text;
                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = txtAddress.Text;
                cmd.Parameters.Add("Postcode", SqlDbType.VarChar).Value = txtPostcode.Text;
                cmd.Parameters.Add("Salary", SqlDbType.Decimal).Value = decimal.Parse(txtSalary.Text);
                cmd.Parameters.Add("StartDate", SqlDbType.Date).Value = txtStartDate.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void Create()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Employee_CREATE", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("Surname", SqlDbType.VarChar).Value = txtSurname.Text;
                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = txtAddress.Text;
                cmd.Parameters.Add("Postcode", SqlDbType.VarChar).Value = txtPostcode.Text;

                cmd.Parameters.Add("Salary", SqlDbType.Decimal).Value = decimal.Parse(txtSalary.Text);

                cmd.Parameters.Add("StartDate", SqlDbType.Date).Value = txtStartDate.Text;
                cmd.Parameters.Add("EmployeeID", SqlDbType.Int).Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                txtEmployeeID.Text = cmd.Parameters["EmployeeID"].Value.ToString();
            }
        }
        private void DeleteProcedure()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Employee_DELETE", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("EmployeeID", SqlDbType.Int).Value = txtEmployeeID.Text;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            createButton.Enabled = true;
        }

        private void ClearTextBoxes()
        {
            List<TextBox> textboxList = new List<TextBox>()
              {
                  txtEmployeeID,
                  txtFirstName,
                  txtSurname,
                  txtAddress,
                  txtPostcode,
                  txtSalary,
                  txtStartDate
              };
            foreach (var txtBox in textboxList)
            {
                txtBox.Text = string.Empty;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcedure();
            btnUpdate.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteProcedure();
            ClearTextBoxes();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var search = new Search();
            search.Show();
        }

        private void DisplayRow()
        {
            
            //var searchWindow = new Search();
            //searchWindow.GETEmployee((int)employeeID);
        }
    }
}
