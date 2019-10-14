using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public Vehicle Vehicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Vehicle.Speed.Add(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Vehicle=new Vehicle(vehicleNameTextBox.Text,regNoTextBox.Text);
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = Vehicle.Speed.Max().ToString();
            minSpeedTextBox.Text = Vehicle.Speed.Min().ToString();
            averageSpeedTextBox.Text = Vehicle.Speed.Average().ToString();
            vehicleNameTextBox.Text = Vehicle.Name;
            regNoTextBox.Text = Vehicle.RegNo;

        }
    }
}
