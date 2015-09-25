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
        private List<ItemModel> saleItems;

        public SaleForm(EmployeeModel employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.label_idOperator.Text = "0000" + employee.EmployeeID.ToString();
            getAllProducts();
            saleItems = new List<ItemModel>();
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
                ItemModel item = null;
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
                            ProductModel product = new ProductModel(Int32.Parse(dataReader["ID"].ToString()),
                                            dataReader["NAME"].ToString(),
                                            dataReader["PROVIDER"].ToString(),
                                            Convert.ToDateTime(dataReader["EXPIRATION_DATE"].ToString()),
                                            Int32.Parse(dataReader["QUANTITY"].ToString()),
                                            Decimal.Parse(dataReader["PURCHASE_PRICE"].ToString()),
                                            Decimal.Parse(dataReader["SALE_PRICE"].ToString()),
                                            dataReader["DESCRIPTION"].ToString());
                            item = new ItemModel(10, product, Int32.Parse(numericUpDown_quantity.Value.ToString()));
                        }
                        sqlConn.Close();
                    }
                }
                updateSale(item);
            } 

        }

        private void updateSale(ItemModel item)
        {
            listBox_saleItems.Items.Clear();
            bool containsIntem = saleItems.Contains(item);
            if (containsIntem)
            {
                foreach (ItemModel model in saleItems)
                {
                    if (model.Equals(item))
                    {
                        model.Quantity += item.Quantity;
                        model.Parcial = model.Quantity * model.Product.SalePrice;
                    }
                }
            }
            else
            {
                saleItems.Add(item);
            }

            decimal total = 0;
            foreach (ItemModel model in saleItems)
            {
                listBox_saleItems.Items.Add(model.Product.ProductName + "   " + model.Quantity + "   " + model.Parcial);
                total += model.Parcial;
            }
            label_value.Text = total.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            label_value.Text = "0,00";
            listBox_saleItems.Items.Clear();
            saleItems.Clear();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale finished with success.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /**   using (SqlConnection sqlConn =
                     new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;"))
               {
                   using (SqlCommand sqlCommand = new SqlCommand())
                   {
                       sqlCommand.CommandText = "INSERT INTO SALE VALUES (@id, @employee, @total, @time)";

                       sqlCommand.Parameters.AddWithValue("id", 10);
                       sqlCommand.Parameters.AddWithValue("employee", employee.EmployeeID);
                       sqlCommand.Parameters.AddWithValue("total", Decimal.Parse(label_value.Text));
                       sqlCommand.Parameters.AddWithValue("time", DateTime.Now);

                       sqlCommand.Connection = sqlConn;
                       sqlConn.Open();

                       sqlCommand.ExecuteNonQuery();

                       foreach (ItemModel item in saleItems)
                       {
                           int i = 10;
                           sqlCommand.CommandText = "INSERT INTO ITEM VALUES (@id, @product, @sale, @quantity)";

                           sqlCommand.Parameters.AddWithValue("id", i++);
                           sqlCommand.Parameters.AddWithValue("product", item.Product.ProductID);
                           sqlCommand.Parameters.AddWithValue("sale", 10);
                           sqlCommand.Parameters.AddWithValue("quantity", item.Quantity);

                           //sqlCommand.ExecuteNonQuery();
                       }

                       sqlConn.Close();
                   }
               }**/
        }
    }
}
