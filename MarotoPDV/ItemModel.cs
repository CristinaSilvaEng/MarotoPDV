using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    class ItemModel
    {
        public int ItemID { get; set; }
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
        public double Parcial { get; set; }
    }
}
