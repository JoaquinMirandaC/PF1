using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class Vegetable : Product
    {
        public Vegetable(int Quantity, double Price) : base(Quantity, Price)
        {
            idProduct = 1;
            name = "Frozen vegetables";
        }
    }
}
