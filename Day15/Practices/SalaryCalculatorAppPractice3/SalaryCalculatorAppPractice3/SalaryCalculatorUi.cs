using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        Employee _employee;
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            _employee = new Employee(employeeNameTextBox.Text, double.Parse(basicAmountTextBox.Text));
            double salary = _employee.ShowTotalSalary(int.Parse(homeRentTextBox.Text), int.Parse(medicalAllowanceTextBox.Text));
            MessageBox.Show(_employee.Name + ", your Salary is: " + salary);

            employeeNameTextBox.Clear();
            basicAmountTextBox.Clear();
            homeRentTextBox.Clear();
            medicalAllowanceTextBox.Clear();
        }
    }
}
