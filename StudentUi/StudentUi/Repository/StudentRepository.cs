using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using StudentUi.Model;
namespace StudentUi.Repository
{
    class StudentRepository
    {
        public bool Add(Student student)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO Students (StudentCode, Name, Address, Contact, DistrictId) Values ('" +student.StudentCode+ "','" + student.Name + "','" + student.Address + "','" + student.Contact + "', '" + student.DistrictId + "')";
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

        public DataTable Display()
        { 
            string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
 
            string commandString = @"SELECT ROW_NUMBER() OVER (ORDER BY s.Id) AS SL,s.Id, s.StudentCode, s.Name as'Student Name', s.Address, s.Contact,s.DistrictId, d.Name as 'District Name' FROM Students as s
                                    LEFT JOIN Districts as d ON d.Id=s.DistrictId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

           
            sqlConnection.Open();
 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;


        }

        public bool SelectById(Student student)
        {

            string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            string commandString = @"SELECT Id, StudentCode, Name, Address, Contact, DistrictId FROM Items WHERE Id='" + student.Id + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                student.Id = Convert.ToInt32(sqlDataReader["Id"]);
                student.StudentCode = sqlDataReader["StudentCode"].ToString();
                student.Name = sqlDataReader["Name"].ToString();
                student.Address = sqlDataReader["Address"].ToString();
                student.Contact = sqlDataReader["Contact"].ToString();
                student.DistrictId = Convert.ToInt32(sqlDataReader["DistrictId"]);

                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }

            sqlDataReader.Close();
            sqlConnection.Close();
            return false;

        }

        public bool Update(Student student)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Students SET StudentCode =  '" + student.StudentCode + "', Name = '" + student.Name+ "',  Address = '" + student.Address + "', Contact = '" + student.Contact + "',  DistrictId = '" +student.DistrictId+ "' WHERE Id = " + student.Id + "";
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

        public bool IsNameExist(Student student)
         
        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Students WHERE StudentCode='" + student.StudentCode + "'";
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
        public bool IsContactExist(Student student)

        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Students WHERE Contact='" + student.Contact + "'";
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

        public List<Student> Search(Student student)
        {
            List<Student> students = new List<Student>();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-K01B49N; Database=StudentInformation; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Students WHERE StudentCode='" + student.StudentCode + "'";
                ////string commandString = @"SELECT * FROM Students";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                while (sqlDataReader.Read())
                {
                    Student stud = new Student();
                    stud.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    stud.StudentCode = sqlDataReader["StudentCode"].ToString();
                    stud.Name = sqlDataReader["Name"].ToString();
                    stud.Address = sqlDataReader["Address"].ToString();
                    stud.Contact = sqlDataReader["Contact"].ToString();
                    stud.DistrictId = Convert.ToInt32(sqlDataReader["DistrictId"]);
                    students.Add(stud);
                }

                sqlConnection.Close();
                return students;
                


            }
            catch (Exception)
            {
                throw; //MessageBox.Show(exeption.Message);
            }
        }
    }
}

