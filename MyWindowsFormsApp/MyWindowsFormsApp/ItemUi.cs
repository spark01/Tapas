using System;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        CustomerManager _customerManager = new CustomerManager();
        Item item = new Item();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

           
            //Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price can not be Empty!!");
                return;
            }
            item.Price = Convert.ToDouble(priceTextBox.Text);
            item.Name = nameTextBox.Text;
            //Unique
            if (_itemManager.IsNameExist(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exist!!");
                return;
            }

            //Add/Insert
            if (_itemManager.Add(item))
            {
                MessageBox.Show("Saved");
                showDataGridView.DataSource = _itemManager.Display();
                Clear();

            }
            else
            {
                MessageBox.Show("Not Saved");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            item.Id = Convert.ToInt32(idTextBox.Text);
            //Delete
            if (_itemManager.Delete(item))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource=_itemManager.Display();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            item.Price = Convert.ToDouble(priceTextBox.Text);
            item.Name = nameTextBox.Text;
            item.Id = Convert.ToInt32(idTextBox.Text);
            if (_itemManager.Update(item))
            {
                MessageBox.Show("Updated");
                showDataGridView.DataSource = _itemManager.Display();
                Clear();


            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Search(nameTextBox.Text);
        }

        

        private void showDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTextBox.Text =  showDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
            nameTextBox.Text = showDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
            priceTextBox.Text = showDataGridView.SelectedRows[0].Cells["Price"].Value.ToString();
            addButton.Visible = false;
        }
        private void Clear()
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            priceTextBox.Text = "";
        }

    }


}
