using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListUI
{
    public partial class ListUI : Form
    {
        private List<String> names = new List<String> { };
        private String message = "";
        public ListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            names.Add(nameTextBox.Text);
            nameTextBox.Text = "";
            ShowCustomer();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void ShowCustomer()
        {
            //for(int i=0; i<names.Count; i++)
            //{
            //    message += names[i] + "\n";
            //}
            //MessageBox.Show(message);

            foreach (String name in names)
            {
                message += name + "\n";
            }
            MessageBox.Show("Customer Name: " + message);
            names.Clear();
        }
    }
}
