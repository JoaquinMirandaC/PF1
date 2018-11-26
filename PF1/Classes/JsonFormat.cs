using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PF1
{
    class JsonFormat
    {
        [JsonProperty("idStore")]
        public int idStore { get; set; }
        [JsonProperty("storeName")]
        public string storeName { get; set; }

        [JsonProperty("products")]
        public List<Product> products { get; set; }

        public JsonFormat()
        { }
        public JsonFormat(Store s)
        {
            products = new List<Product>();
            idStore = s.StoreId;
            storeName = s.StoreName;
            products = s.StoreOrder.NumberOfProducts();

        }

    }
}
