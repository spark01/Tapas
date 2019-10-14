using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator calculator = new Calculator();
        private double reg;
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.SeceoandNumber = Convert.ToInt32(secondNumberTextBox.Text);
            secondNumberTextBox.Clear();
            firstNumberTextBox.Clear();

           
            resultTextBox.Text = calculator.Add( ).ToString();
            

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.SeceoandNumber = Convert.ToInt32(secondNumberTextBox.Text);
            secondNumberTextBox.Clear();
            firstNumberTextBox.Clear();
            resultTextBox.Text = calculator.Sub().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.SeceoandNumber = Convert.ToInt32(secondNumberTextBox.Text);
            secondNumberTextBox.Clear();
            firstNumberTextBox.Clear();
            resultTextBox.Text = calculator.Mul().ToString();

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.SeceoandNumber = Convert.ToInt32(secondNumberTextBox.Text);
            secondNumberTextBox.Clear();
            firstNumberTextBox.Clear();
            resultTextBox.Text = calculator.Div().ToString();

        }
    }
}
