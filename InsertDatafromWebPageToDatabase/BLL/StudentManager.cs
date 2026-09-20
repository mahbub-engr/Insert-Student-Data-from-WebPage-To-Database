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
            
            int rowAffect = studentGateway.SaveStudent(student);
            if (rowAffect > 0)
            {
                return "Save Successfully";
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
    }

}