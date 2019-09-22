using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1
{
    public partial class fireRangeAutomationSystemForm : Form
    {
        Boolean inputValid;
        int count = 0;
        double score, avg;

        List<String> soldierNos = new List<String> { };
        List<String> soldierNames = new List<String> { };
        List<String> target1Scores = new List<String> { };
        List<String> target2Scores = new List<String> { };
        List<String> target3Scores = new List<String> { };
        List<String> target4Scores = new List<String> { };

        List<String> totalScores = new List<String> { };
        List<String> averageScores = new List<String> { };

        public fireRangeAutomationSystemForm()
        {
            InitializeComponent();
        }

        private void fireRangeAutomationSystemForm_Load(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            inputValid = ValidateInputs();
            GetData();
        }

        private void GetData()
        {
            try
            {
                if (inputValid)
                {
                    soldierNos.Add(soldierNoTextBox.Text);
                    soldierNames.Add(soldierNameTextBox.Text);
                    target1Scores.Add(target1ScoreTextBox.Text);
                    target2Scores.Add(target2ScoreTextBox.Text);
                    target3Scores.Add(target3ScoreTextBox.Text);
                    target4Scores.Add(target4ScoreTextBox.Text);

                    score = double.Parse(target1ScoreTextBox.Text) + double.Parse(target2ScoreTextBox.Text) +
                            double.Parse(target3ScoreTextBox.Text) + double.Parse(target4ScoreTextBox.Text);
                    avg = score / 4.00;

                    totalScores.Add(score + "");
                    averageScores.Add(avg + "");

                    count++;
                    ClearInputs();

                    MessageBox.Show("Soldier Added");

                    EnableButtons();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClearInputs()
        {
            soldierNoTextBox.Text = "";
            soldierNameTextBox.Text = "";
            target1ScoreTextBox.Text = "";
            target2ScoreTextBox.Text = "";
            target3ScoreTextBox.Text = "";
            target4ScoreTextBox.Text = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowAllInformation();
            ClearInputs();

            TopScorerName();
            TopAverageScorerName();
        }

        private void TopAverageScorerName()
        {
            try
            {
                String name = "";
                double averageScore = double.Parse(averageScores.Max());
                for (int i = 0; i < soldierNos.Count; i++)
                {
                    if (averageScore == double.Parse(averageScores[i]))
                    {
                        name += soldierNames[i];
                        topAverageScorerTextBox.Text = name;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void TopScorerName()
        {
            try
            {
                String name = "";
                double topScore = double.Parse(totalScores.Max()) ;
                for (int i = 0; i < soldierNos.Count; i++)
                {
                    if (topScore == double.Parse(totalScores[i]))
                    {
                        name += soldierNames[i];
                        topTotalScorerTextBox.Text = name;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowAllInformation()
        {

            String message = "";
            try
            {
                if (!(soldierNos.Count == 0))
                {
                    for (int i = 0; i < soldierNos.Count; i++)
                    {

                        message += "Soldier No: " + soldierNos[i] +
                        "\nSoldier Name: " + soldierNames[i] +
                        "\nTarget 1 Score: " + target1Scores[i] +
                        "\nTarget 3 Score: " + target2Scores[i] +
                        "\nTarget 3 Score: " + target3Scores[i] +
                        "\nTarget 4 Score: " + target4Scores[i] +
                        "\nAverage Score: " + averageScores[i] +
                        "\nTotal Score: " + totalScores[i] +
                        "\n------------------------------------\n";


                    }
                    soldierListRichTextBox.Text = message;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (soldierNoRadioButton.Checked)
            {
                if (!searchTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < soldierNos.Count; i++)
                    {
                        if (searchTextBox.Text == soldierNos[i])
                        {
                            information += "Soldier No: " + soldierNos[i] +
                                            "\nSoldier Name: " + soldierNames[i] +
                                            "\nAverage Score: " + averageScores[i] +
                                            "\nTotal Score: " + totalScores[i] +
                                            "\n-------------------------\n";
                        }
                    }
                    if (information == "")
                    {
                        MessageBox.Show("Soldier Not Found!");
                        searchTextBox.Text = "";
                    }
                    else
                    {
                        soldierListRichTextBox.Text = information;
                        MessageBox.Show("Soldier Found!!");
                        searchTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input Soldier number");
                }
            }else if (soldierNameRadioButton.Checked)
            {
                if (!searchTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < soldierNos.Count; i++)
                    {
                        if (searchTextBox.Text == soldierNames[i])
                        {
                            information += "Soldier No: " + soldierNos[i] +
                                            "\nSoldier Name: " + soldierNames[i] +
                                            "\nAverage Score: " + averageScores[i] +
                                            "\nTotal Score: " + totalScores[i] +
                                            "\n-------------------------\n";
                        }
                    }
                    if (information == "")
                    {
                        MessageBox.Show("Soldier Not Found!");
                        searchTextBox.Text = "";
                    }
                    else
                    {
                        soldierListRichTextBox.Text = information;
                        MessageBox.Show("Soldier Found!!");
                        searchTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Input Soldier Name");
                }
            }
            else
            {
                MessageBox.Show("First choose an option!");
            }
        }

        private Boolean ValidateInputs()
        {
            inputValid = false;
            if (!inputValid)
            {
                if (soldierNoTextBox.Text == "" || soldierNos.Contains(soldierNoTextBox.Text))
                {
                    if (soldierNoTextBox.Text == "")
                    {
                        MessageBox.Show("id can not be empty!!");
                        return false;
                    }
                    else if (soldierNos.Contains(soldierNoTextBox.Text))
                    {
                        MessageBox.Show("Soldier already exist.");
                        return false;
                    }
                }

                return true;
            }
            return inputValid;
        }

        private void DisableButtons()
        {
            showAllButton.Enabled = false;
            searchButton.Enabled = false;
        }
        private void EnableButtons()
        {
            showAllButton.Enabled = true;
            searchButton.Enabled = true;
        }

        private void target1ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        private void target2ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        private void target3ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        private void target4ScoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInput(e);
        }

        private void NumberInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers...");
            }
        }

        private void soldierNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextInput(e);
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
