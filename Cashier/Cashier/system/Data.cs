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
        private static int lastId = 0;
        public Data() {
            Id = GenerateUniqueId();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        // If this is meant to be a connection string, it might be better placed in your configuration file.
        static string myconnstrng = ConfigurationManager.ConnectionStrings[""].ConnectionString;
    
        private int GenerateUniqueId()
        {
            return ++lastId;
        }
    }


}
