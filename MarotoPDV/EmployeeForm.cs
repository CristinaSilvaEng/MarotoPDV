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
    public partial class EmployeeForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;";

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "INSERT INTO EMPLOYEE VALUES (@id, @name, @password, @level, @address, @telephone)";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Parameters.AddWithValue("name", textBox_name.Text);
                    sqlCommand.Parameters.AddWithValue("password", textBox_password.Text);
                    sqlCommand.Parameters.AddWithValue("level", comboBox_level.Text);
                    sqlCommand.Parameters.AddWithValue("address", textBox_address.Text);
                    sqlCommand.Parameters.AddWithValue("telephone", maskedTextBox_telephone.Text);

                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
                MessageBox.Show("Create with success.");
                clean_form();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "UPDATE EMPLOYEE SET NAME = @name, PASSWORD = @password, LEVEL = @level, ADDRESS = @address, TELEPHONE = @telephone WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Parameters.AddWithValue("name", textBox_name.Text);
                    sqlCommand.Parameters.AddWithValue("password", textBox_password.Text);
                    sqlCommand.Parameters.AddWithValue("level", comboBox_level.Text);
                    sqlCommand.Parameters.AddWithValue("address", textBox_address.Text);
                    sqlCommand.Parameters.AddWithValue("telephone", maskedTextBox_telephone.Text);

                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
                MessageBox.Show("Update with success.");
                clean_form();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "DELETE FROM EMPLOYEE WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
                MessageBox.Show("Delete with success.");
                clean_form();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM EMPLOYEE WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

                    EmployeeModel employee = null;
                    if (dataReader.Read())
                    {
                        employee = new EmployeeModel(Int32.Parse(dataReader["ID"].ToString()),
                                            dataReader[1].ToString(),
                                            dataReader[2].ToString(),
                                            Int32.Parse(dataReader["LEVEL"].ToString()),
                                            dataReader[4].ToString(),
                                            dataReader[5].ToString());
                    }
                    sqlConn.Close();


                    if (employee != null)
                    {
                        textBox_id.Text = employee.EmployeeID.ToString();
                        textBox_name.Text = employee.EmployeeName.ToString();
                        textBox_password.Text = employee.Password.ToString();
                        comboBox_level.Text = employee.Level.ToString();
                        textBox_address.Text = employee.Address.ToString();
                        maskedTextBox_telephone.Text = employee.Telephone.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Empty result");
                        clean_form();
                    }
                }
            }
        }

        private void clean_form()
        {
            textBox_id.ResetText();
            textBox_name.ResetText();
            textBox_password.ResetText();
            comboBox_level.ResetText();
            textBox_address.ResetText();
            maskedTextBox_telephone.ResetText();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
