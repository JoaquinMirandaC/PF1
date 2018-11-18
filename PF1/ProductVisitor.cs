using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class ProductVisitor:Visitor
    {
        public double TotalCost { get; set; }

        public ProductVisitor()
        {
            TotalCost = 0;
        }
        public override void Visit(Product product)
        {
            TotalCost += (product.Quantity * product.Price);
        }

      
    }
}
