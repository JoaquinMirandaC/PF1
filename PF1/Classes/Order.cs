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
        public List<Product> NumberOfProducts()
        {
            CountVisitor visitor = new CountVisitor();
            foreach (Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            List<Product> countes = visitor.CountedProducts;
            return countes;
        }
    }
}
