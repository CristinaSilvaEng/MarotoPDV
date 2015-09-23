using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    class SaleModel
    {
        public SaleModel()
        {
            Items = new HashSet<ItemModel>();
        }

        public int SaleID { get; set; }
        public EmployeeModel Employee { get; set; }
        public double Total { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<ItemModel> Items { get; set; }
    }
}
