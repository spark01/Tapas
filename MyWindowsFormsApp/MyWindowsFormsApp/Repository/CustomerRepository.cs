using System;
using System.Data.SqlClient;
using System.Data;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.Repository
{
    class CustomerRepository
    {
        public bool Add(string name, string address,string contact)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @" INSERT INTO Customer (Name, Address, Contact) VALUES('"+name+"', '"+ address + "','"+contact+"')"; 
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }



                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }

        public bool IsNameExist(string name)
        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return isExist;
        }

        public bool Delete(int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Customer WHERE ID = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return false;
        }
        public bool Update(string name, string address, string contact, int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Customer SET Name =  '" + name + "' , Address = '" + address + "', Contact = '" + contact + "' WHERE Id = " + id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return false;
        }

        public DataTable Display()
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("No Data Found");
            //}

            //Close

            sqlConnection.Close();
            return dataTable;

            //}
            //catch (Exception exeption)
            //{
            //    //MessageBox.Show(exeption.Message);
            //}
        }

        public DataTable Search(string name)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Name='" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }

        public DataTable CustomerCombo()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Id, Name, Address, Contact FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;

        }
    }
}
