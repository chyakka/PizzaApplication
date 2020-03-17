using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApplication.Classes
{
    /* Basic User Details */
    public class User
    {
        public User(string name, string address, string postcode)
        {
            UserName = name;
            Address = address;
            PostCode = postcode;
        }

        public string UserName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
    }
}



