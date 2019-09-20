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
        Boolean inputValid;
        int count = 0;

        List<String> ids = new List<String> { };
        List<String> names = new List<String> { };
        List<String> mobiles = new List<String> { };
        List<String> ages = new List<String> { };
        List<String> addresses = new List<String> { };
        List<String> gpaPoints = new List<String> { };

        public LabTestForm()
        {
            InitializeComponent();
            DisableButtons();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            inputValid = ValidateInputs();
            GetData();

            UncheckRadioButton();
        }
        private void GetData()
        {
            try
            {
                if (inputValid)
                {
                    ids.Add(idTextBox.Text);
                    names.Add(nameTextBox.Text);
                    mobiles.Add(mobileTextBox.Text);
                    ages.Add(ageTextBox.Text);
                    addresses.Add(addressTextBox.Text);
                    gpaPoints.Add(gpaPointTextBox.Text);

                    count++;
                    SetData();
                    ClearInputs();

                    MessageBox.Show("Information added successfully.");

                    EnableButtons();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void SetData()
        {
            try
            {
                String message = "Student Number: " + count +
                        "\nID: " + idTextBox.Text +
                        "\nName: " + nameTextBox.Text +
                        "\nMobile: " + mobileTextBox.Text +
                        "\nAge: " + ageTextBox.Text +
                        "\nAddress: " + addressTextBox.Text +
                        "\nGPA: " + gpaPointTextBox.Text;

                outputRichTextBox.Text = message;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllInformation();
            CalculateGpaPoint();
            ClearInputs();

            UncheckRadioButton();
        }

        private void CalculateGpaPoint()
        {
            MaxGPA();
            MinGPA();
            AvgGPA();
            TotalGPA();
        }

        private void ShowAllInformation()
        {
            String message = "";
            try
            {
                if (!(ids.Count == 0))
                {
                    for (int i = 0; i < ids.Count; i++)
                    {
                        message += "Student: " + (i + 1) +
                        "\nID: " + ids[i] +
                        "\nName: " + names[i] +
                        "\nMobile: " + mobiles[i] +
                        "\nAge: " + ages[i] +
                        "\nAddress: " + addresses[i] +
                        "\nGPA: " + gpaPoints[i] +
                        "\n------------------------------------\n";
                    }
                    outputRichTextBox.Text = message;
                }
                else
                {
                    MessageBox.Show("No data found!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private double TotalGPA()
        {
            double sum = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                sum += double.Parse(gpaPoints[i]);
            }
            totalPointTextBox.Text = sum + "";

            return sum;
        }
        private void AvgGPA()
        {
            double sum = TotalGPA();
            double avg = sum / ids.Count;

            avgPointTextBox.Text = avg + "";
        }
        private void MinGPA()
        {
            try
            {
                String name = "";
                double min = double.Parse(gpaPoints.Min());
                minPointTextBox.Text = min + "";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (min == double.Parse(gpaPoints[i]))
                    {
                        name += names[i] + ", ";
                    }
                }
                minNameTextBox.Text = name;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void MaxGPA()
        {
            try
            {
                String name = "";
                double max = double.Parse(gpaPoints.Max());
                maxPointTextBox.Text = max + "";
                for (int i = 0; i < ids.Count; i++)
                {
                    if (max == double.Parse(gpaPoints[i]))
                    {
                        name += names[i] + ", ";
                    }
                }
                maxNameTextBox.Text = name;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (idRadioButton.Checked)
            {
                if (!idTextBox.Text.Equals(""))
                {
                    String information = "";
                    for(int i=0; i<ids.Count; i++)
                    {
                        if(idTextBox.Text == ids[i])
                        {
                            information += "ID: " + ids[i] +
                                            "\nName: " + names[i] +
                                            "\nMobile: " + mobiles[i] + 
                                            "\nAge: " + ages[i] +
                                            "\nAddress: " + addresses[i] +
                                            "\nGPA: " + gpaPoints[i] +
                                            "\n-------------------------\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given ID !!");
                        outputRichTextBox.Text = "";
                    }
                    else
                    {
                        outputRichTextBox.Text = information;
                        MessageBox.Show("Data Found!!");
                    }
                }
                else
                {
                    MessageBox.Show("Input ID number");
                }
            }
            else if (nameRadioButton.Checked)
            {
                if (!nameTextBox.Text.Equals(""))
                {
                    String information = "";
                    for(int i=0; i<ids.Count; i++)
                    {
                        if(nameTextBox.Text == names[i])
                        {
                            information += "ID: " + ids[i] +
                                            "\nName: " + names[i] +
                                            "\nMobile: " + mobiles[i] +
                                            "\nAge: " + ages[i] +
                                            "\nAddress: " + addresses[i] +
                                            "\nGPA: " + gpaPoints[i] +
                                            "\n-------------------------\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given Name !!");
                        outputRichTextBox.Text = "";
                    }
                    else
                    {
                        outputRichTextBox.Text = information;
                        MessageBox.Show("Data Found !!");
                    }
                }
                else
                {
                    MessageBox.Show("Input a name");
                }
            }
            else if (mobileRadioButton.Checked)
            {
                if (!mobileTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < ids.Count; i++)
                    {
                        if (mobileTextBox.Text == names[i])
                        {
                            information += "ID: " + ids[i] +
                                            "\nName: " + names[i] +
                                            "\nMobile: " + mobiles[i] +
                                            "\nAge: " + ages[i] +
                                            "\nAddress: " + addresses[i] +
                                            "\nGPA: " + gpaPoints[i] +
                                            "\n-------------------------\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given Mobile !!");
                        outputRichTextBox.Text = "";
                    }
                    else
                    {
                        outputRichTextBox.Text = information;
                        MessageBox.Show("Data Found !!");

                    }

                }
                else
                {
                    MessageBox.Show("Input a mobile number");
                }
            }
            else
            {
                MessageBox.Show("Check a button first!");
            }

            ClearInputs();
        }


        private void DisableButtons()
        {
            showButton.Enabled = false;
            searchButton.Enabled = false;
        }
        private void EnableButtons()
        {
            showButton.Enabled = true;
            searchButton.Enabled = true;
        }

        private Boolean ValidateInputs()
        {
            inputValid = false;
            if (!inputValid)
            {
                if (idTextBox.Text == "" || idTextBox.Text.Length < 4 || ids.Contains(idTextBox.Text))
                {
                    if (idTextBox.Text == "")
                    {
                        MessageBox.Show("id can not be empty!!");
                        return false;
                    }
                    else if (idTextBox.Text.Length < 4)
                    {
                        MessageBox.Show("Id must be 4 character long!!");
                        return false;
                    }
                    else if (ids.Contains(idTextBox.Text))
                    {
                        MessageBox.Show("ID already exist.");
                        return false;
                    }
                }
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("name can not be empty!!");
                    return false;
                }
                if (mobileTextBox.Text == "" || mobileTextBox.Text.Length < 11 || mobiles.Contains(mobileTextBox.Text)) 
                {
                    if(mobileTextBox.Text == "")
                    {
                        MessageBox.Show("mobile can not be empty!!");
                        return false;
                    }else if(mobileTextBox.Text.Length < 11)
                    {
                        MessageBox.Show("Mobile number must be 11 character long!!");
                        return false;
                    }else if (mobiles.Contains(mobileTextBox.Text))
                    {
                        MessageBox.Show("Mobile number already exist.");
                        return false;
                    }
                }
                if(double.Parse(gpaPointTextBox.Text) > 4.00 || double.Parse(gpaPointTextBox.Text) < 0.00)
                {
                    MessageBox.Show("Input GPA between 0.00 to 4.00!");
                    return false;
                }

                return true;
            }
            return inputValid;
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
        private void UncheckRadioButton()
        {
            idRadioButton.Checked = false;
            nameRadioButton.Checked = false;
            mobileRadioButton.Checked = false;
        }

        private void mobileTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }
        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }
        private void gpaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatInput(e);
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
        }

        private void NumberInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers...");
            }
        }
        private void FloatInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("input valid gpa");
            }
        }
        private void TextInput(KeyPressEventArgs e)
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
