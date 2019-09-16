﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class ConditionUI : Form
    {
        public ConditionUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (itemComboBox.Text.Equals(""))
            {
                MessageBox.Show("Please Select item !!");
            }else
            {
                MessageBox.Show(itemComboBox.Text + " is selected");
            }
        }
    }
}
