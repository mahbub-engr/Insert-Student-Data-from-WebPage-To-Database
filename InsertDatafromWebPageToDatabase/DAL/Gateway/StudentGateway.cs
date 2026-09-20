using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InsertDatafromWebPageToDatabase.DAL.Gateway
{
    public class StudentGateway
    {
        public int SaveStudent(Student student)
        {
            string conString = "server=.;database=StudentDBTest;integrated security=true";
            SqlConnection connection = new SqlConnection(conString);
            string insertQuery = @"insert into Students (Name,RegistrationNumber,Depertment,Age,Address) Values (@Name,@RegistrationNumber,@Depertment,@Age,@Address)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@RegistrationNumber", student.RegNo);
            cmd.Parameters.AddWithValue("@Depertment", student.Depertment);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            cmd.Parameters.AddWithValue("@Address", student.Address);
            connection.Open();
            int res = cmd.ExecuteNonQuery();
            connection.Close();
            return res;
        }
        public DataTable GetAllStudents()
        {
            string conString = "server=.;database=StudentDBTest;integrated security=true";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = @"SELECT StudentID,
                                    Name,
                                    RegistrationNumber,
                                    Depertment,
                                    Age,
                                    Address
                             FROM Students";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}