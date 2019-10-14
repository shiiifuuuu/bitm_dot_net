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
        List<double> _speeds = new List<double>();
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
            _vehicle.Speed = double.Parse(speedTextBox.Text);

            _speeds.Add(_vehicle.Speed);

            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = _speeds.Min()+"";
            maxSpeedTextBox.Text = _speeds.Max()+"";
            averageSpeedTextBox.Text = _speeds.Average()+"";
        }
    }
}
