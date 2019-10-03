using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.Repository
{
    class ItemRepository
    {
        public bool Add(Item item)
        {
            bool isAdded = false;
            try
            {
               
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                
                string commandString = @"INSERT INTO Items (Name, Price) Values ('" + item.Name + "', " + item.Price+ ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

               
                sqlConnection.Open();
               
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }



              
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
                string commandString = @"SELECT * FROM Items WHERE Name='" + name + "'";
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

        public bool Delete(Item item)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Items WHERE ID = " + item.Id + "";
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

        public bool Update(Item item)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Items SET Name =  '" + item.Name + "' , Price = " + item.Price + " WHERE ID = " + item.Id + "";
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
                string commandString = @"SELECT * FROM Items";
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

        public DataTable IDwiseDisplay(int id)
        {
           
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

           
            string commandString = @"SELECT Price FROM Items where ID= '" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

           
            sqlConnection.Open();

           
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
          

            sqlConnection.Close();
            return dataTable;

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
                string commandString = @"SELECT * FROM Items WHERE Name='" + name + "'";
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

        public DataTable ItemCombo()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Id, Name FROM Items";
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

        public bool SelectById(int Id, string Name, double Price)
        {
             
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

             
            string commandString = @"SELECT Id, Name, Price FROM Items WHERE Id='"+ Id + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

             
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while(sqlDataReader.Read())
            {
                Id = Convert.ToInt32(sqlDataReader["Id"]);
                Name = sqlDataReader["Name"].ToString();
                Price = Convert.ToDouble(sqlDataReader["Price"]);

                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }

            sqlDataReader.Close();
            sqlConnection.Close();
            return false;

        }
    }
}
