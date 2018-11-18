using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public abstract class Product:Visitable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(int Quantity, double Price)
        {
            this.Quantity = Quantity;
            this.Price = Price;
        }
        /// <summary>
        /// Accept the visitor
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
