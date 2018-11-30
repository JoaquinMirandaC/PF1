using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class BreadTrucks : ProductHandler
    {
        public BreadTrucks(int n_trucks)
        {
            //hardcoded the capacity of these trucks
            int numberofproducts_truck = 270;
            this.Capacity = n_trucks * numberofproducts_truck;
        }
        public override Dictionary<int, int> ProcessRequest(Dictionary<int, int> inventory)
        {
            int bread_id = 3;
            //hardcoded the ID of the specific Handler Product
            if (inventory.ContainsKey(bread_id))
            {
                inventory[bread_id] = inventory[bread_id] - Capacity;
            }
            return inventory;

        }
    }
}
