using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUnit
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public string GreetingCustomer(string firstname, string lastname)
        {
            GreetMessage = $"hello,{firstname} {lastname}";
            return GreetMessage;
        }
    }
}
