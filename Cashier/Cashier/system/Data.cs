using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.system
{
    internal class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[""].ConnectionString;

    }
}
