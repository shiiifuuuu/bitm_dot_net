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
            enterButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _refrigerator = new Refrigerator(double.Parse(maximumWeightTextBox.Text));
            maximumWeightTextBox.ReadOnly = true;
            enterButton.Enabled = true;
        }

        private int count = 0;
        private void enterButton_Click(object sender, EventArgs e)
        {
            _refrigerator.ItemNo.Add(int.Parse(itemNoTextBox.Text));
            _refrigerator.ItemWeight.Add(double.Parse(itemWeightTextBox.Text));

            double totalWeight = _refrigerator.CalculateWeight(count);
            count++;

            if (_refrigerator.Validate(totalWeight))
            {
                currentWeightTextBox.Text = _refrigerator.CurrentWeight(totalWeight) + "";
                remainingWeightTextBox.Text = _refrigerator.RemainingWeight() + "";

                showRichTextBox.Text = _refrigerator.ShowValue();
            }
            else
            {
                MessageBox.Show("Weight Overflow!!");
            }

            itemNoTextBox.Clear();
            itemWeightTextBox.Clear();
        }
    }
}
