using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Account
    {
        public string AccountNo { set; get; }
        public double balance;
        public string OpeningDate { set; get; }

        public Account(string accountNo, string openingDate):this()
        {
            AccountNo = accountNo;
            OpeningDate = openingDate;
        }

        public Account()
        {
            balance = 0;
        }

        internal void Deposit(string amount)
        {
            balance += double.Parse(amount);
        }

        internal void Withdraw(string amount)
        {
            balance -= double.Parse(amount);
        }
    }
}
