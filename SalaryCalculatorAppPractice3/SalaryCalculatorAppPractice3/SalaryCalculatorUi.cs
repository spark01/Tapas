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
        Salary salary = new Salary();
        public double total;
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            salary.employeeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salary.houseRent= Convert.ToDouble(homeRentTextBox.Text);
            salary.madicaleAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            total = salary.Totalsalary();
            employeeNameTextBox.Clear();
            basicAmountTextBox.Clear();
            homeRentTextBox.Clear();
            medicalAllowanceTextBox.Clear();

            MessageBox.Show(salary.employeeName +"Your Total Salary " +total.ToString());

        }
    }
}
