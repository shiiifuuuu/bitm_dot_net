using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountAppExample1
{
    public partial class CustomerAndAccountUi : Form
    {
        Customer _customer;
        Account _customerAccount;
        public CustomerAndAccountUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _customerAccount = new Account(accountNumberTextBox.Text, openingDateTextBox.Text);
            _customer = new Customer(customerNameTextBox.Text, emailTextBox.Text, _customerAccount);
        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            _customerAccount.Deposit(amountTextBox.Text);
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            _customerAccount.Withdraw(amountTextBox.Text);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            customerName2TextBox.Text = _customer.Name;
            email2TextBox.Text = _customer.Email;
            accountNumber2TextBox.Text = _customer.CustomerAccount.AccountNo;
            openingDate2TextBox.Text = _customer.CustomerAccount.OpeningDate;
            BalanceTextBox.Text = _customer.CustomerAccount.balance+"";
        }

        private void CustomerAndAccountUi_Load(object sender, EventArgs e)
        {
            _customer = new Customer();
        }
    }
}
