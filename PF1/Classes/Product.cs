﻿using System;
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
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }

        public Product() { }
        public Product(int Quantity, double Price)
        {
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}