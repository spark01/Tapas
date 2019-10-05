using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using StudentUi.Model;


namespace StudentUi.Repository
{
    class DistrictRepository
    {
        public bool Add(District district)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

              

                string commandString = @"INSERT INTO Districts (Name) Values ('" +district.Name+ "')";
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

        public List<District> loadCombo()
        {
            List<District> Districtst = new List<District>();

            try
            {
                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT distinct '0' as Id,'Please Select Distict' as Name FROM Districts
                                      union all
                                     SELECT Id,Name FROM Districts";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

 

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    District district = new District();
                    district.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    district.Name = sqlDataReader["Name"].ToString();
                    Districtst.Add(district);
                }

                sqlConnection.Close();
                



            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Districtst;
        }
    }

   
}
