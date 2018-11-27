using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PF1
{
    public class Product:Visitable
    {

        [JsonProperty("idProduct")]
        public int idProduct { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("quantity")]
        public int quantity { get; set; }
        [JsonProperty("price")]
        public double price { get; set; }

        public Product() { }
        public Product(int Quantity, double Price)
        {
            this.quantity = Quantity;
            this.price = Price;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
