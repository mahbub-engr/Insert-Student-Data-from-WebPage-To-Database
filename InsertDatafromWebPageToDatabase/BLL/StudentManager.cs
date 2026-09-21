using InsertDatafromWebPageToDatabase.DAL.Gateway;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InsertDatafromWebPageToDatabase.BLL
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();
        public string SaveStudent (Student student)
        {
            
            int StudentID = studentGateway.SaveStudent(student);
            if (StudentID > 0)
            {
                return StudentID.ToString();
            }
            else
            {
                return "Failed to Save ";
            }
        }

        public DataTable GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        
        }
        public DataTable GetStudentById(int studentId)
        {
            return studentGateway.GetStudentById(studentId);
        }
    }

}