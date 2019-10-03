using System;
using System.Data.SqlClient;
using System.Data;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.Repository
{
    class OrderRepository
    {
        public bool Add(Order order)
        {
            bool isAdded = false;
            try
            {
                
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                double totalpricr = order.Quantity *order.Price;
                
                string commandString = @"INSERT INTO Orders (CustomerId, ItemId, Quantity, TotalPrice) Values ('" +order.CustomerId + "','" + order.ItemId+ "','" + order.Quantity + "','" + totalpricr + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                
                sqlConnection.Open();
              
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

        public bool Delete(int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM QuantityOrder WHERE ID = " + id + "";
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

        public DataTable Display()
        {
            //try
            //{
            //Connection
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT o.Id, c.Name as 'Customer Name',i.Name as 'Item Name', Quantity,i.Price,Quantity*i.Price as TotalPrice FROM Orders AS o
                                     LEFT JOIN Customers AS c ON c.Id = o.CustomerId
                                     LEFT JOIN Items AS i ON i.Id = o.ItemId";
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

        public bool Update(int quantity, int id)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE QuantityOrder SET Quantity =  '" + quantity + "'  WHERE ID = " + id + "";
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

        public DataTable Search(int quantity)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM QuantityOrder WHERE Quantity='" + quantity + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
               
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }
    }
}
