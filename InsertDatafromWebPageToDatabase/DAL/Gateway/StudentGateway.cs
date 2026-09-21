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
        private string conString = "server=.;database=StudentDBTest;integrated security=true";
        public int SaveStudent(Student student)
        {

            SqlConnection connection = new SqlConnection(conString);
            string insertQuery = "spAddStudent";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",SqlDbType.NVarChar).Value=student.Name;
            cmd.Parameters.AddWithValue("@RegistrationNumber", SqlDbType.NVarChar ).Value= student.RegNo;
            cmd.Parameters.AddWithValue("@Department", SqlDbType.NVarChar).Value= student.Department;
            cmd.Parameters.AddWithValue("@Age",SqlDbType.Int ).Value= student.Age;
            cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar ).Value= student.Address;
            connection.Open();
            object result = cmd.ExecuteScalar();
            connection.Close();
            return (result !=null && result!=DBNull.Value)? Convert.ToInt32(result):0;
        }
        public DataTable GetAllStudents()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = @"spGetStudents";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetStudentById(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = @"spGetStudents";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}