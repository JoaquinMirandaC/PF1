using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCodeEncoderDecoderLibrary;
using Newtonsoft.Json;

namespace PF1
{
    public class Order
    {     
        public List<Visitable> products { get; set; }
        public double OrderValue { get; set; }
        public Order()
        {
            products = new List<Visitable>();
        }

        public void OrderCost()
        {
            ProductVisitor visitor = new ProductVisitor();
            foreach(Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            double totalCost = visitor.TotalCost;
            OrderValue = totalCost;
        }

        public void AddItems(Product product)
        {
            products.Add(product);
        }

        public List<Product> ListOfProducts()
        {
            ListVisitor visitor = new ListVisitor();
            foreach (Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            List<Product> count = visitor.CountedProducts;
            return count;
        }

        public Dictionary<int, int> Inventory(Dictionary<int, int> current)
        {
            InventoryVisitor visitor = new InventoryVisitor(current);
            foreach (Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            Dictionary<int, int> inven = visitor.inventory;
            return inven;
        }
    }
}
