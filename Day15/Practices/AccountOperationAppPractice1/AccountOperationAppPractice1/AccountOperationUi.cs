using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account _account;
        public AccountOperationUi()
        {
            InitializeComponent();
            DipositButton.Enabled = false;
            WithdrawButton.Enabled = false;
            ReportButton.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _account = new Account(accountNoTextBox.Text, customerNameTextBox.Text);

            CreateButton.Enabled = false;
            accountNoTextBox.ReadOnly = true;
            customerNameTextBox.ReadOnly = true;
            DipositButton.Enabled = true;
            WithdrawButton.Enabled = true;
            ReportButton.Enabled = true;
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(amountTextBox.Text);
                _account.Deposit(amount);
                MessageBox.Show(amount + " tk deposited to your account");
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(amountTextBox.Text);
                if (_account.Withdraw(amount) == 1)
                {
                    MessageBox.Show("You dont have sufficient balance! Your balance is: " + _account.balance);
                }
                else
                {
                    MessageBox.Show(amount + " tk withdrawed from your account");
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_account.GetReport());
        }

    }
}
