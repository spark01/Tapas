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
        Vehicle vehicle = new Vehicle();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.Set(vehicleNameTextBox.Text,regNoTextBox.Text);
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vehicle.SetSpeed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(vehicle.GetMax() + " " + vehicle.GetMin() + " " + vehicle.GetAvg());
            minSpeedTextBox.Text = vehicle.GetMin().ToString();
            maxSpeedTextBox.Text = vehicle.GetMax().ToString();
            averageSpeedTextBox.Text = vehicle.GetAvg().ToString();
        }
    }
}
