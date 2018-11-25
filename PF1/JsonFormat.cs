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
        public int StoreId { get; set; }
        [JsonProperty("storeName")]
        public string StoreName { get; set; }

        [JsonProperty("products")]
        public List<Product> products { get; set; }

        public JsonFormat()
        { }
        public JsonFormat(Store s)
        {
            products = new List<Product>();
            StoreId = s.StoreId;
            StoreName = s.StoreName;
            
            StoreId = s.StoreId;
            StoreName = s.StoreName;
            ProductCreator factory = new ConcreteProductCreator();
            foreach (Visitable p in s.StoreOrder.products)
            {
                Product ap = (Product)p;
                Product item = factory.ProductFactory(ap.Id, ap.Quantity, ap.Price);
                products.Add(item);
            }

        }

    }
}
