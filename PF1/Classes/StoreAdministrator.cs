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
        public static void UpdateDeliverToday()
        {
            foreach(var store in StoreListToday)
                store.StoreOrder.OrderCost();

            List<Store> SortedList = StoreListToday.OrderByDescending(o => o.StoreOrder.OrderValue).ToList();
            StoreListToday = SortedList;
        }


        public static Dictionary<int, int> InventoryTomorrow()
        {
            Dictionary<int, int> inventory = new Dictionary<int, int>();
            foreach(Store s in StoreListTomorrow)
                inventory = s.StoreOrder.Inventory(inventory);

            return inventory;
        }
    }
}
