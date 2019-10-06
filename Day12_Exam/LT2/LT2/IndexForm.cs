using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LT2
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveForm form1 = new SaveForm();
            form1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByPriceRangeForm form1 = new SearchByPriceRangeForm();
            form1.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchByImeiForm form1 = new SearchByImeiForm();
            form1.ShowDialog();
        }
    }
}
