using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account account = new Account();
       
       
        private double amount;
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
             account.accountNumber = accountNoTextBox.Text;
             account.customerName = customerNameTextBox.Text;

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            amount = account.Deposit(Convert.ToDouble(amountTextBox.Text));
            amountTextBox.Clear();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            amount = account.Widthraw(Convert.ToDouble(amountTextBox.Text));
            amountTextBox.Clear();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = (account.blance).ToString();
            MessageBox.Show("Ac: "+ account.accountNumber + "  "+"Customer Name: "+ account.customerName + "  "+"Balance:  "+ amount);
        }
    }
}
