using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public static class StoreAdministrator
    {
        public static List<Store> StoreListToday;
        public static List<Store> StoreListTomorrow;
        

        public static void Start()
        {
            StoreListToday = new List<Store>();
            StoreListTomorrow = new List<Store>();
        }

        //public static void AddStoreFromString(string s, string path)
        //{
        //    var builder= new StoreJBuilder(s);
        //    var director = new StoreDirector();
        //    director.Construct(builder);
        //    Store finalStore = builder.GetStore();
        //    finalStore.LastOrderPath = path;
        //    StoreListToday.Add(finalStore);
        //}
        public static void UpdateDeliverToday()
        {
            foreach(var store in StoreListToday)
            {
                store.StoreOrder.OrderCost();
            }

            List<Store> SortedList = StoreListToday.OrderByDescending(o => o.StoreOrder.orderValue).ToList();
            StoreListToday = SortedList;
        }

        public static bool OrdersReady()
        {
            return StoreListToday.Count == StoreListTomorrow.Count;
        }
    }
}
