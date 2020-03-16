using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication.Classes
{
    public class Order
    {
        public List<Item> Items = new List<Item>();

        // Method that lets us check if the Items list has a specific item in it.
        public bool ContainsItem(string name)
        {
            foreach(Item item in Items)
            {
                if(item.ItemName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveItem(string name)
        {
            foreach(Item item in Items.ToList())
            {
                if(item.ItemName == name)
                {
                    Items.Remove(item);
                }
            }
        }
    }
}
