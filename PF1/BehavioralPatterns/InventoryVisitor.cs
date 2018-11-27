using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    public class InventoryVisitor : Visitor
    {
        public Dictionary<int, int> inventory;

        public InventoryVisitor(Dictionary<int, int> received)
        {
            inventory = received;
        }

        public override void Visit(Product product)
        {
            //method to add counted id or value to dictionary
            int pID = product.idProduct;
            int amount = product.quantity;
            if (inventory.ContainsKey(pID))
            {
                int value = inventory[pID] + amount;
                inventory[pID] = value;
            }
            else
                inventory.Add(pID, amount);
        }
    }
}
