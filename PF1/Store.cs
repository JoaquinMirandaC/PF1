using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PF1
{
    public class Store
    {
        [JsonProperty("idStore")]
        public int StoreId { get; set; }
        [JsonProperty("storeName")]
        public string  StoreName { get; set; }
        [JsonIgnore]
        public string LastOrderPath { get; set; }
        //[JsonProperty("products")]
        public Order StoreOrder { get; set; }


        public override string ToString()
        {
            return $"{StoreId} {StoreName} {StoreOrder.OrderJson()}";
        }
    }
}
