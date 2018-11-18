using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class StoreBuilder : AbstractStoreBuilder
    {
        private int sId;
        private string sName;
        private List<string> sProducts;

        private Store store;
        public StoreBuilder(string s)
        {
            sProducts = new List<string>();
            store = new Store();
            int cont = 0;
            foreach (String token in s.Split())
            {
                if (cont == 0)
                    sId = Convert.ToInt32(token);
                else if (cont == 1)
                    sName = token;
                else
                    sProducts.Add(token);
                cont++;
            }

        }
        public override void BuildId()
        {
            store.StoreId = sId;
        }
        public override void BuildName()
        {
            store.StoreName = sName;
        }
        public override void BuildOrder()
        {
            Order pedido = new Order();
            foreach(String token in sProducts)
            {
                int cont = 0;
                int tempId = -1;
                int tempPr = 0;
                int tempQ = 0;

                foreach(String element in token.Split(','))
                {
                    if (cont == 0)
                        tempId = Convert.ToInt32(element);
                    if (cont == 2)
                        tempPr = Convert.ToInt32(element);
                    if (cont == 3)
                        tempQ = Convert.ToInt32(element);

                    cont++;
                }

                //factory
                ProductCreator factory = new ConcreteProductCreator();
                Product item = factory.ProductFactory(tempId, tempQ, tempPr);
                pedido.AddItems(item);
                
            }
            store.StoreOrder = pedido;
        }
        public override Store GetStore()
        {
            return store;
        }

    }
}
