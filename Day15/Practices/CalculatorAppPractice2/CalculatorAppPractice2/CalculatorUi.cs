using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator _calculator;
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _calculator = new Calculator(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text));
                resultTextBox.Text = _calculator.Add() + "";
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                _calculator = new Calculator(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text));
                resultTextBox.Text = _calculator.Subtract() + "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                _calculator = new Calculator(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text));
                resultTextBox.Text = _calculator.Multiply() + "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                _calculator = new Calculator(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text));
                resultTextBox.Text = _calculator.Divide() + "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
