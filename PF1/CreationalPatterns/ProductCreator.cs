using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    abstract class ProductCreator
    {
        public abstract Product ProductFactory(int id, int quantity,double price);
    }
}
