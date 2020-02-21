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

        public float TotalCost()
        {
            float totalCost = 0;
            foreach(Item item in Items)
            {
                totalCost += item.ItemCost;
            }
            return totalCost;
        }
    }
}
