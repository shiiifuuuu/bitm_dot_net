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
        private List<String> name = new List<String> { };
        private String message = "";
        public ListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            name.Add(nameTextBox.Text);
            nameTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<name.Count; i++)
            {
                message += name[i] + "\n";
            }
            MessageBox.Show(message);
        }
    }
}
