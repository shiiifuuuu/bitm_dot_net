using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string AccountNo { set; get; }
        public string Name { set; get; }
        public double balance = 0;

        public Account(string accountNo, string name)
        {
            this.AccountNo = accountNo;
            this.Name = name;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public int Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public string GetReport()
        {
            return (Name + ", your account number: " + AccountNo + " and it's balance: " + balance + " taka");
        }
    }
}
