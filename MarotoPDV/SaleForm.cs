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
            getAllProducts();
        }

        private void button_searchID_Click(object sender, EventArgs e)
        {
            listBox_products.Items.Clear();
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
                        listBox_products.Items.Add(String.Format("{0,-32}  {1,12}  {2,3}", dataReader["NAME"].ToString().Trim(),
                            dataReader["PROVIDER"].ToString().Trim(), dataReader["QUANTITY"].ToString().Trim()));
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

        private void getAllProducts()
        {
            listBox_products.Items.Clear();
            using (SqlConnection sqlConn =
                  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM PRODUCT";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();
                    Console.WriteLine(dataReader);
                    while (dataReader.Read())
                    {
                        listBox_products.Items.Add(String.Format("{0,-32}  {1,12}  {2,3}", dataReader["NAME"].ToString().Trim(), 
                            dataReader["PROVIDER"].ToString().Trim(), dataReader["QUANTITY"].ToString().Trim()));
                    }
                    sqlConn.Close();
                }
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.ResetText();
            getAllProducts();
        }

        private void button_cart_Click(object sender, EventArgs e)
        {
            if (numericUpDown_quantity.Value > 0 && listBox_products.Items.Count == 1)
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
                            listBox_saleItems.Items.Add(String.Format("{0,-32}  {1,3}", dataReader["NAME"].ToString().Trim()
                                , numericUpDown_quantity.Value.ToString()));
                        }
                        sqlConn.Close();
                    }
                }
            } 

        }
    }
}
