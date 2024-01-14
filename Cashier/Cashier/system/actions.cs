using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Google.Protobuf.WellKnownTypes;
using Cashier.system;

namespace Cashier.System
{
    internal class Actions
    {
        public void AddItem(Product item)
        {
            item.Id = item.generateUniqueId();
            // Copy other properties
            // Note: It's unnecessary to copy properties manually, as you've already set them above.
        }

        public Product[] ShowItems()
        {
            // Assuming you have a collection of products somewhere, replace 'ProductCollection' with your actual product collection.
            return ProductCollection.ToArray();
        }

        public void SetOwner(Owner owner)
        {
            // Copy properties from owner parameter
            // Note: It's unnecessary to copy properties manually, as you've already set them above.
        }

        public Owner GetOwner()
        {
            // Assuming you have an owner object somewhere, replace 'OwnerInstance' with your actual owner instance.
            return OwnerInstance;
        }

        public void EditItem(int id, string field, string value)
        {
            Product product = GetProductById(id);
            if (product == null)
            {
                // Handle product not found
                return;
            }

            switch (field.ToLower())
            {
                case "name":
                    product.Name = value;
                    break;
                case "category":
                    product.Category = value;
                    break;
                case "price":
                    if (int.TryParse(value, out int price))
                    {
                        product.Price = price;
                    }
                    else
                    {
                        // Handle invalid price format
                    }
                    break;
                case "quantity":
                    if (int.TryParse(value, out int quantity))
                    {
                        product.Quantity = quantity;
                    }
                    else
                    {
                        // Handle invalid quantity format
                    }
                    break;
                default:
                    // Handle unknown field
                    break;
            }
        }

        public void DeleteItem(int id)
        {
            Product product = GetProductById(id);
            if (product != null)
            {
                // Assuming you have a method to remove a product from your collection
                ProductCollection.Remove(product);
            }
            // Handle product not found
        }

        public void Purchase(int id)
        {
            Product product = GetProductById(id);
            if (product != null && product.Quantity > 0)
            {
                Owner owner = GetOwner();
                owner.TotalProfits += product.Price;
                product.Quantity -= 1;
            }
            // Handle product not found or out of stock
        }

        private Product GetProductById(int id)
        {
            // Assuming you have a method to get a product by its ID
            return ProductCollection.FirstOrDefault(p => p.Id == id);
        }
    }
}
