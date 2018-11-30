using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class VegetableTrucks:ProductHandler
    {
        public VegetableTrucks(int n_trucks)
        {
            //hardcoded the capacity of these trucks
            int numberofproducts_truck = 95;
            this.Capacity = n_trucks * numberofproducts_truck;
        }
        public override Dictionary<int, int> ProcessRequest(Dictionary<int, int> inventory)
        {
            int vegetable_id = 1;
            //hardcoded the ID of the specific Handler Product
            if (inventory.ContainsKey(vegetable_id))
            {
                inventory[vegetable_id] = inventory[vegetable_id] - Capacity;
            }

            successor.ProcessRequest(inventory);

            return inventory;

        }
    }
}
