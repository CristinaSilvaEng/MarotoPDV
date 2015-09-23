using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarotoPDV
{
    public class EmployeeModel
    {
        public EmployeeModel(int id, string name, string passord, int level, string address, string telephone)
        {
            this.EmployeeID = id;
            this.EmployeeName = name;
            this.Password = passord;
            this.Level = level;
            this.Address = address;
            this.Telephone = telephone;
        }

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
    }
}
