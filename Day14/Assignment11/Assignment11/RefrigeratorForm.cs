using Assignment11.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment11
{
    public partial class RefrigeratorForm : Form
    {
        Refrigerator _refrigerator;

        public RefrigeratorForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _refrigerator = new Refrigerator(double.Parse(maximumWeightTextBox.Text));
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double itemWeight = double.Parse(itemWeightTextBox.Text);
            double remainingWeight = _refrigerator.MaximumWeight;

            if (itemWeight <= remainingWeight)
            {
                currentWeightTextBox.Text = _refrigerator.CurrentWeight(double.Parse(itemWeightTextBox.Text)) + "";
                remainingWeight = remainingWeight - itemWeight;

                remainingWeightTextBox.Text = _refrigerator.RemainingWeight(remainingWeight)+"";
            }
            else
            {
                MessageBox.Show("Weight Overflow!!");
            }
        }
    }
}
