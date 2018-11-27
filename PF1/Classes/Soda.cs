using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class Soda:Product
    {
        public Soda(int Quantity, double Price) :base(Quantity, Price)
        {
            idProduct = 2;
            name = "Sodas";
        }
    }
}
