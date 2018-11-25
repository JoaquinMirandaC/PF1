using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace PF1
{
    class StoreJBuilder : AbstractStoreBuilder
    {
        private int sId;
        private string sName;
        private List<string> sProducts;
        private JsonFormat fromJson;

        private Store store;
        public StoreJBuilder(string s)
        {
            JObject jObject = JObject.Parse(s);
            fromJson = new JavaScriptSerializer().Deserialize<JsonFormat>(s);
            store = new Store();
 

        }
        public override void BuildId()
        {
            store.StoreId = fromJson.StoreId;
        }
        public override void BuildName()
        {
            store.StoreName = fromJson.StoreName;
        }
        public override void BuildOrder()
        {
            Order order = new Order();
            foreach(var product in fromJson.products)
            {
                order.AddItems(product);
            }

            store.StoreOrder = order;
        }
        public override Store GetStore()
        {
            return store;
        }

    }
}
