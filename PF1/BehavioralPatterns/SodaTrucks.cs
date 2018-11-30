using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class SodaTrucks : ProductHandler
    {
        public SodaTrucks(int n_trucks)
        {
            //hardcoded the capacity of these trucks
            int numberofproducts_truck = 120;
            this.Capacity = n_trucks * numberofproducts_truck;
        }
        public override Dictionary<int, int> ProcessRequest(Dictionary<int, int> inventory)
        {
            int soda_id = 2;
            //hardcoded the ID of the specific Handler Product
            if (inventory.ContainsKey(soda_id))
            {
                inventory[soda_id] = inventory[soda_id] - Capacity;
            }

            successor.ProcessRequest(inventory);

            return inventory;

        }
    }
}
