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
            int itemNo = int.Parse(itemNoTextBox.Text);

            if(double.Parse(itemWeightTextBox.Text) <= _refrigerator.MaximumWeight)
            {
                double currentWeight = _refrigerator.CurrentWeight(double.Parse(itemWeightTextBox.Text));


                if (double.Parse(currentWeightTextBox.Text) <= _refrigerator.MaximumWeight)
                {
                    
                    remainingWeightTextBox.Text = _refrigerator.RemainingWeight() + "";
                }
            }
            else
            {
                MessageBox.Show("Weight Overflow!");
            }
            
        }
    }
}
