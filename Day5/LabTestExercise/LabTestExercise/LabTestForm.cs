using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTestExercise
{
    public partial class LabTestForm : Form
    {
        Boolean inputValid = false;
        List<String> ids = new List<String> { };
        List<String> names = new List<String> { };
        List<String> mobiles = new List<String> { };
        List<String> ages = new List<String> { };
        List<String> addresses = new List<String> { };
        List<String> gpaPoints = new List<String> { };

        public LabTestForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            checkCondition();

            if (inputValid)
            {
                ids.Add(idTextBox.Text);
                names.Add(nameTextBox.Text);
                mobiles.Add(mobileTextBox.Text);
                ages.Add(ageTextBox.Text);
                addresses.Add(addressTextBox.Text);
                gpaPoints.Add(gpaPointTextBox.Text);
                MessageBox.Show("COMPLETE");
                ClearInputs();
            }
            
        }
        private void checkCondition()
        {
            if(inputValid == false)
            {
                if (idTextBox.Text == "" || idTextBox.Text.Length < 4 || ids.Contains(idTextBox.Text))
                {
                    if (idTextBox.Text == "")
                    {
                        MessageBox.Show("id can not be empty!!");
                    }
                    else if (idTextBox.Text.Length < 4)
                    {
                        MessageBox.Show("Id must be 4 character long!!");
                    }
                    else if (ids.Contains(idTextBox.Text))
                    {
                        MessageBox.Show("ID already exist.");
                    }
                }
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("name can not be empty!!");
                }
                if (mobileTextBox.Text == "" || mobileTextBox.Text.Length < 11 || mobiles.Contains(mobileTextBox.Text)) 
                {
                    if(mobileTextBox.Text == "")
                    {
                        MessageBox.Show("mobile can not be empty!!");
                    }else if(mobileTextBox.Text.Length < 11)
                    {
                        MessageBox.Show("Mobile number must be 11 character long!!");
                    }else if (mobiles.Contains(mobileTextBox.Text))
                    {
                        MessageBox.Show("Mobile number already exist.");
                    }
                }
                return ;
            }
            inputValid = true;
        }

        private void ClearInputs()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaPointTextBox.Text = "";
        }












        private void mobileTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberInput(e);
        }
        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberInput(e);
        }
        private void gpaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(e);
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textInput(e);
        }

        private void numberInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers...");
            }
        }
        private void floatInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("input valid gpa");
            }
        }
        private void textInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only alphabetic characters");
            }
        }
    }
}
