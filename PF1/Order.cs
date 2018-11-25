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
        [JsonProperty("products")]
        public List<Visitable> products { get; set; }
        [JsonIgnore]
        public double orderValue { get; set; }
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
            orderValue = totalCost;
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
        //find a way to count how many products of each type
        public List<int> NumberOfProducts()
        {
            CountVisitor visitor = new CountVisitor();
            foreach (Visitable obj in products)
            {
                obj.Accept(visitor);
            }
            List<int> countes = visitor.CountedProducts;
            return countes;
        }
    }
}
