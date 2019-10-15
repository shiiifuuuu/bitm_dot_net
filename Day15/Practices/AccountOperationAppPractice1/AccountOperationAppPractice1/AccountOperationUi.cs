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
        Account account = new Account();
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            account.accountNo = accountNoTextBox.Text;
            account.name = customerNameTextBox.Text;

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            account.balance = double.Parse(amountTextBox.Text);
            account.Deposit(account.balance);
            amountTextBox.Clear();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string report = account.GetReport();
            MessageBox.Show(report);
        }
    }
}
