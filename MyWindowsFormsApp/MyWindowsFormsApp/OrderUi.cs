using System;
using System.Data;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp
{
    public partial class OrderUi : Form
    {
        OrderManager _orderManager = new OrderManager();
        ItemManager _itemManager = new ItemManager();
        CustomerManager _customerManager = new CustomerManager();
        public OrderUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity can not be Empty!!");
                return;
            }
         


            order.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
            order.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            order.Quantity = Convert.ToInt32(quantityTextBox.Text);
           // order.TotalPrice= Convert.ToDouble(priceTextBox.Text);

            DataTable dt = _itemManager.IDwiseDisplay(Convert.ToInt32(itemComboBox.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                order.Price = Double.Parse(dt.Rows[0]["Price"].ToString());
            }


            if (_orderManager.Add(order))
            {
                MessageBox.Show("added");
                showDataGridView.DataSource = _orderManager.Display();
            }
        }

       

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _orderManager.Display();
        }

 

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity can not be Empty!!");
                return;
            }
            showDataGridView.DataSource = _orderManager.Search(Convert.ToInt32(quantityTextBox.Text));

        }

        private void OrderUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _itemManager.ItemCombo();
            customerComboBox.DataSource = _customerManager.CustomerCombo();

        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
