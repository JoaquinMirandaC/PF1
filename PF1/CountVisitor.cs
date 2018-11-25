using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class CountVisitor:Visitor
    {
        public List<int> CountedProducts { get; set; }

        public CountVisitor()
        {
            CountedProducts = new List<int>();
        }
        public override void Visit(Product product)
        {
            //TotalCost += (product.Quantity * product.Price);
        }

      
    }
}
