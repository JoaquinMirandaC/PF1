using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class ListVisitor:Visitor
    {
        public List<Product> CountedProducts { get; set; }

        public ListVisitor()
        {
            CountedProducts = new List<Product>();
        }

        public override void Visit(Product product)
        {
            CountedProducts.Add(product);
        }
    }
}
