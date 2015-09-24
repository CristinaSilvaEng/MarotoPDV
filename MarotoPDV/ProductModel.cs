using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    class ProductModel
    {

        public ProductModel(int id, string name, string provider, DateTime expirationDate, int quatity, decimal purchasePrice, decimal salePrice, string description)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.Provider = provider;
            this.ExpirationDate = expirationDate;
            this.Quantity = quatity;
            this.PurchasePrice = purchasePrice;
            this.SalePrice = salePrice;
            this.Description = description;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Provider { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
    }
}
