using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Cashier.system
{
    internal class Actions
    {
        public void addItem(Product item)
        {
            item.Id = item.generateUniqueId();
            // Copy other properties
            item.Name = item.Name;
            item.Category = item.Category;
            item.Price = item.Price;
            item.Quantity = item.Quantity;
        }
    }
}
