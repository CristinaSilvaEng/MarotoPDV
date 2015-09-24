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
    public partial class ProductForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarotoDB.mdf;Integrated Security=True;";

        public ProductForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "INSERT INTO PRODUCT VALUES (@id, @name, @provider, @expiration_date, @quantity, @purchase_price, @sale_price, @description)";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Parameters.AddWithValue("name", textBox_name.Text);
                    sqlCommand.Parameters.AddWithValue("provider", textBox_fornecedor.Text);
                    sqlCommand.Parameters.AddWithValue("expiration_date", dateTimePicker_data_validade.Value);
                    sqlCommand.Parameters.AddWithValue("quantity", Int32.Parse(textBox_qtd_estoque.Text));
                    sqlCommand.Parameters.AddWithValue("purchase_price", Decimal.Parse(textBox_preco_compra.Text));
                    sqlCommand.Parameters.AddWithValue("sale_price", Decimal.Parse(textBox_preco_venda.Text));
                    sqlCommand.Parameters.AddWithValue("description", textBox_descricao.Text);

                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM PRODUCT WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();
                    SqlDataReader dataReader;
                    dataReader = sqlCommand.ExecuteReader();

                    ProductModel product = null;
                    if (dataReader.Read())
                    {
                        product = new ProductModel(Int32.Parse(dataReader["ID"].ToString()),
                                            dataReader["NAME"].ToString(),
                                            dataReader["PROVIDER"].ToString(),
                                            Convert.ToDateTime(dataReader["EXPIRATION_DATE"].ToString()),
                                            Int32.Parse(dataReader["QUANTITY"].ToString()),
                                            Decimal.Parse(dataReader["PURCHASE_PRICE"].ToString()),
                                            Decimal.Parse(dataReader["SALE_PRICE"].ToString()),
                                            dataReader["DESCRIPTION"].ToString());
                    }
                    sqlConn.Close();


                    if (product != null)
                    {
                        textBox_id.Text = product.ProductID.ToString();
                        textBox_name.Text = product.ProductName.ToString();
                        textBox_fornecedor.Text = product.Provider.ToString();
                        dateTimePicker_data_validade.Text = product.ExpirationDate.ToString();
                        textBox_qtd_estoque.Text = product.Quantity.ToString();
                        textBox_preco_compra.Text = product.PurchasePrice.ToString();
                        textBox_preco_venda.Text = product.SalePrice.ToString();
                        textBox_descricao.Text = product.Description.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Empty result");
                    }
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "UPDATE PRODUCT SET NAME = @name, PROVIDER = @provider, EXPIRATION_DATE = @expiration_date, " +
                                                    "QUANTITY = @quantity, PURCHASE_PRICE = @purchase_price, SALE_PRICE = @sale_price, DESCRIPTION = @description WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Parameters.AddWithValue("name", textBox_name.Text);
                    sqlCommand.Parameters.AddWithValue("provider", textBox_fornecedor.Text);
                    sqlCommand.Parameters.AddWithValue("expiration_date", dateTimePicker_data_validade.Value);
                    sqlCommand.Parameters.AddWithValue("quantity", Int32.Parse(textBox_qtd_estoque.Text));
                    sqlCommand.Parameters.AddWithValue("purchase_price", Decimal.Parse(textBox_preco_compra.Text));
                    sqlCommand.Parameters.AddWithValue("sale_price", Decimal.Parse(textBox_preco_venda.Text));
                    sqlCommand.Parameters.AddWithValue("description", textBox_descricao.Text);

                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "DELETE FROM PRODUCT WHERE ID = @id";

                    sqlCommand.Parameters.AddWithValue("id", textBox_id.Text);
                    sqlCommand.Connection = sqlConn;
                    sqlConn.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConn.Close();
                }
            }
        }
    }
}
