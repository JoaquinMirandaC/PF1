using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public abstract class Visitor
    {
        public abstract void Visit(Product product);
    }
}
