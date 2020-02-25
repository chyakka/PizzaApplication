﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication.Classes
{
    /* Our item class that will use an enum to distinguish different types of items in the order */
    public class Item
    {
        public Item(string name, float cost, Type type)
        {
            ItemName = name;
            ItemCost = cost;
            ItemType = type;
        }

        public string ItemName { get; set; }
        public float ItemCost { get; set; }

        public enum Type { Starter, Topping, Base, Sweet}
        public Type ItemType { get; set; }
    }
}
