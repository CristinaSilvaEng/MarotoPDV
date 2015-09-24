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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = doLogin(textBox_username.Text, textBox_password.Text);
            if (employee == null)
            {
                label_errorLogin.Show();
            }
            else
            {
                switch (employee.Level)
                {
                    case 0:
                        this.Hide();
                        SaleForm saleForm = new SaleForm(employee);
                        saleForm.Closed += (s, args) => this.Close();
                        saleForm.Show();
                        break;
                    case 1:
                        //produto
                        break;
                    case 2:
                        this.Hide();
                        EmployeeForm employeeForm = new EmployeeForm();
                        employeeForm.Closed += (s, args) => this.Close();
                        employeeForm.Show();
                        break;
                    default:
                        break;
                }
            }
            
        }

        private EmployeeModel doLogin(string username, string password)
        {
            EmployeeModel employee = null;
            using (SqlConnection sqlConn =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Parameters.AddWithValue("username", username);
                    sqlCommand.Parameters.AddWithValue("password", password);
                    sqlCommand.CommandText = "SELECT * FROM EMPLOYEE WHERE NAME = @username AND PASSWORD = @password";
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

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
                }
            }
            return employee;
        }

    }
}
