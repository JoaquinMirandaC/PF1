using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class ConcreteProductCreator : ProductCreator
    {
        public override Product ProductFactory(int id, int quantity, int price)
        {
            Product product = null;
            if (id == 0)
                product = new Soda(quantity, price);
            else if (id == 1)
                product = new Bread(quantity, price);
            else if (id == 2)
                product = new Vegetable(quantity, price);

            return product;
        }
    }
}
