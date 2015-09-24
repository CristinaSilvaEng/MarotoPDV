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
                                            dataReader[1].ToString(),
                                            dataReader[2].ToString(),
                                            Convert.ToDateTime(dataReader["EXPIRATION_DATE"]),
                                            Int32.Parse(dataReader["QUANTITY"].ToString()),
                                            Decimal.Parse(dataReader[4].ToString()),
                                            Decimal.Parse(dataReader[5].ToString()),
                                            dataReader[6].ToString());
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

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
