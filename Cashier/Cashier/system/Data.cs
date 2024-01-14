using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.system
{
    internal class Product
    {
        private static int lastProductId = 0;

        public Product()
        {
            Id = GenerateUniqueId();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        // If this is meant to be a connection string, it might be better placed in your configuration file.
        private static string myconnstrng = ConfigurationManager.ConnectionStrings[""].ConnectionString;

        private int GenerateUniqueId()
        {
            return ++lastProductId;
        }

        internal int generateUniqueId()
        {
            throw new NotImplementedException();
        }
    }

    internal class Owner
    {
        public string BusinessName { get; set; }
        public string Logo { get; set; }
        public decimal TotalProfits { get; set; }

        // Additional properties related to the owner can be added here.
    }


}
