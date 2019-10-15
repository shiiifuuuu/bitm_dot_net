using Assignment10.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class VehicleForm : Form
    {
        Vehicle _vehicle = new Vehicle();
        //List<double> _speeds = new List<double>();
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _vehicle = new Vehicle(vehicleNameTextBox.Text, regNoTextBox.Text);

            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();

            MessageBox.Show("Vehicle " + _vehicle.Name + ", Reg No: " + _vehicle.RegNo + " created");
            createButton.Enabled = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            _vehicle.SetSpeed(double.Parse(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = _vehicle.MinSpeed()+"";
            maxSpeedTextBox.Text = _vehicle.MaxSpeed() + "";
            averageSpeedTextBox.Text = _vehicle.AvgSpeed() + "";
        }
    }
}
