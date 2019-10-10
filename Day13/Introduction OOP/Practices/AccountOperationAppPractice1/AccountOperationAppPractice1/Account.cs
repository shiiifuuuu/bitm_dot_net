using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string accountNo;
        public string name;
        public double balance;

        public string GetReport()
        {
            string report = name + ", your account number: " + accountNo + " and it's balance: " + balance + " taka";
            return report;
        }
        public double Deposit(double balance)
        {
            double totalAmount=0;
            totalAmount += balance;
            return totalAmount;
        }
        public void Withdraw()
        {

        }
    }
}
