using System;
 
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp
{
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (_customerManager.IsNameExist(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exist!!");
                return;
            }
            if (String.IsNullOrEmpty(addresTextBox.Text))
            {
                MessageBox.Show("addres can not be Empty!!");
                return;
            }

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("addres can not be Empty!!");
                return;
            }

            if (_customerManager.Add(nameTextBox.Text, addresTextBox.Text, contactTextBox.Text))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            if (_customerManager.Delete(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            if (String.IsNullOrEmpty(addresTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            if (_customerManager.Update(nameTextBox.Text, addresTextBox.Text, contactTextBox.Text,  Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
                //showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Display();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            showDataGridView.DataSource = _customerManager.Search(nameTextBox.Text);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
