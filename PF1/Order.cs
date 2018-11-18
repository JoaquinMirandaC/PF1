using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class Order
    {
        public List<Visitable> products;
        public Order()
        {
            products = new List<Visitable>();
        }
        public double OrderCost()
        {
            ProductVisitor visitor = new ProductVisitor();
            foreach(Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            double totalCost = visitor.TotalCost;
            return totalCost;
        }
        public void AddItems(Product product)
        {
            products.Add(product);
        }
        public string OrderJson()
        {
            JsonVisitor visitor = new JsonVisitor();
            foreach (Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            string orderJson = visitor.OrderString;
            return orderJson;
        }
    }
}
