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

namespace MarotoPDV
{
    public partial class SaleForm : Form
    {
        private EmployeeModel employee;

        public SaleForm(EmployeeModel employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.label_idOperator.Text = "0000" + employee.EmployeeID.ToString();
        }

        private void button_searchID_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.CommandText = "SELECT * FROM PRODUCT WHERE ID = @id";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        listView_products.Items.Add(String.Format("{0,-40}  {1,-12}  {2,3}",
                            dataReader["NAME"].ToString(), dataReader["PROVIDER"].ToString(), dataReader["QUANTITY"].ToString()));
                    }
                    sqlConn.Close();
                }
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void button_name_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("name", textBox_name.Text);
                    sqlCommand.CommandText = "SELECT * FROM PRODUCT WHERE NAME LIKE '%@name%'";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        listView_products.Items.Add(String.Format("{0,-40}  {1,-12}  {2,3}",
                            dataReader["NAME"].ToString(), dataReader["PROVIDER"].ToString(), dataReader["QUANTITY"].ToString()));
                    }
                    sqlConn.Close();
                }
            }
        }

        private void button_provider_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("provider", textBox_provider.Text);
                    sqlCommand.CommandText = "SELECT * FROM PRODUCT WHERE PROVIDER LIKE '%@provider%'";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        listView_products.Items.Add(String.Format("{0,-40}  {1,-12}  {2,3}",
                            dataReader["NAME"].ToString(), dataReader["PROVIDER"].ToString(), dataReader["QUANTITY"].ToString()));
                    }
                    sqlConn.Close();
                }
            }
        }
    }
}
