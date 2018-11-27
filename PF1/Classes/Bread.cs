using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class Bread:Product
    {
        public Bread(int Quantity, double Price) : base(Quantity, Price)
        {
            idProduct = 3;
            name = "Bread";
        }
    }
}
