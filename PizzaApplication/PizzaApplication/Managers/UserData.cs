using PizzaApplication.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication.Managers
{
    /* Our static class will allow easy reference between our forms */
    public static class UserData
    {
        public static User user;
        public static Order order = new Order();
    }
}
