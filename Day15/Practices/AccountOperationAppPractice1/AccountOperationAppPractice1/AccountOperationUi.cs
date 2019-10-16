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
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _account = new Account(accountNoTextBox.Text, customerNameTextBox.Text);

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            _account.Deposit(double.Parse(amountTextBox.Text));
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_account.GetReport());
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            _account.Withdraw(double.Parse(amountTextBox.Text));
        }
    }
}
