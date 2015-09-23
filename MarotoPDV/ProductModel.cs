using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Provider { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
    }
}
