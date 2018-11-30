using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    abstract class ProductHandler
    {

        protected int Capacity;
        protected ProductHandler successor;

        public void SetSuccessor(ProductHandler successor)
        {
            this.successor = successor;
        }

        public abstract Dictionary<int, int> ProcessRequest(Dictionary<int, int> inventory);
    }
}
