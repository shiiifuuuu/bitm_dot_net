using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryAppPractice1
{
    public partial class EmployeeSalaryUi : Form
    {
        Employee _employee=new Employee();
        public EmployeeSalaryUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _employee = new Employee();
            _employee.Id = IdTextBox.Text;
            _employee.Name = nameTextBox.Text;
            _employee.Email = emailTextBox.Text;
            _employee.Salary.Basic = double.Parse(basicTextBox.Text);
            _employee.Salary.Medical = double.Parse(medicalTextBox.Text);
            _employee.Salary.Conveyance = double.Parse(conveyanceTextBox.Text);

            _employee.Salary.CalculateMedicalAmount(_employee.Salary.Medical);
            _employee.Salary.CalculateConveyanceAmount(_employee.Salary.Conveyance);
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            _employee.Salary.increase++;
            _employee.Salary.CalculateIncreaseAmount(double.Parse(increaseTextBox.Text));

            _employee.Salary.Medical = _employee.Salary.CalculateMedicalAmount(_employee.Salary.Medical);
            _employee.Salary.Conveyance = _employee.Salary.CalculateConveyanceAmount(_employee.Salary.Conveyance);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            noOfIncrementsTextBox.Text = _employee.Salary.increase + "";
            showBasicTextBox.Text = _employee.Salary.Basic + "";
            showMedicalTextBox.Text = _employee.Salary.Medical + "";
            showConveyanceTextBox.Text = _employee.Salary.Conveyance + "";
            showTotalTextBox.Text = _employee.Salary.GetTotal() + "";
        }
    }
}
