using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaApplication.Classes;
using PizzaApplication.Managers;

namespace PizzaApplication.Managers
{
    public static class BasketManager
    {
        public static void UpdateBasketDisplay(ListBox listBox)
        {
            listBox.Items.Clear();   
            foreach(Item item in UserData.order.Items)
            {
                listBox.Items.Add($"{item.ItemName} ({item.ItemType})");
            }
            listBox.Items.Add(string.Empty);
        }
    }
}
