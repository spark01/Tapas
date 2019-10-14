using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    { 
        SalaryCount salaryCount= new SalaryCount();

        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {

            salaryCount.employeeName = employeeNameTextBox.Text;
            salaryCount.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salaryCount.houseRent = Convert.ToDouble(homeRentTextBox.Text);
            salaryCount.madicaleAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

           salaryCount.Show();
        }

        private void ShowMeSalaryButton_Click_1(object sender, EventArgs e)
        {
            salaryCount.employeeName = employeeNameTextBox.Text;
            salaryCount.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salaryCount.houseRent = Convert.ToDouble(homeRentTextBox.Text);
            salaryCount.madicaleAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            salaryCount.Show();
        }
    }
}

