using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class Store
    {
        public int StoreId { get; set; }
        public string  StoreName { get; set; }
        public Order StoreOrder { get; set; }


        public override string ToString()
        {
            return $"{StoreId} {StoreName} {StoreOrder.OrderJson()}";
        }
    }
}
