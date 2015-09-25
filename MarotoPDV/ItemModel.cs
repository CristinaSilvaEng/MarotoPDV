using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    class ItemModel
    {
        public ItemModel(int itemID, ProductModel product, int quantity)
        {
            this.ItemID = itemID;
            this.Product = product;
            this.Quantity = quantity;
            Parcial = quantity * product.SalePrice;
        }

        public int ItemID { get; set; }
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
        public decimal Parcial { get; set; }

        public override bool Equals(object obj)
        {
            ItemModel other = (ItemModel)obj;
            return other.Product.ProductID == this.Product.ProductID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        
    }
}
