using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV.Model
{
    class Sale
    {
        public Sale()
        {
            Items = new HashSet<Item>();
        }

        public int SaleID { get; set; }
        public Employee Employee { get; set; }
        public double Total { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
