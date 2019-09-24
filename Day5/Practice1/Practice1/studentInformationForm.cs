using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class studentInformationForm : Form
    {
        public studentInformationForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                MessageBox.Show("DONE");
            }
        }

        private void idTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idTextBox.Text))
            {
                e.Cancel = true;
                idTextBox.Focus();
                errorProvider.SetError(idTextBox, "ID can not be empty");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(idTextBox, null);
            }
        }
    }
}
