using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Customer
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public Account CustomerAccount;

        public Customer(string name, string email, Account customerAccount):this()
        {
            Name = name;
            Email = email;
            CustomerAccount = customerAccount;
        }

        public Customer()
        {
            CustomerAccount = new Account();
        }
    }
}
