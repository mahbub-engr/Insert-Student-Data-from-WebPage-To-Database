using InsertDatafromWebPageToDatabase.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsertDatafromWebPageToDatabase
{
    public partial class IndexUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LoadStudents();
            //}
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AgeText.Text.Trim(),out int ParsedAge))
            {
                OutputLabel.Text = "Pleace enter valid age";
                return;
            }
            Student student = new Student();
            student.Name = NameText.Text.Trim();
            student.Age = ParsedAge;
            student.Department = DeptText.Text;
            student.RegNo = RegText.Text;
            student.Address = AddressText.Text;
            
           string result=studentManager.SaveStudent(student);
            if (int.TryParse(result,out int newStudentID))
            {
                StudentGridView.DataSource = studentManager.GetStudentById(newStudentID);
                StudentGridView.DataBind();
                ClearForm();
            }
            else
            {
                OutputLabel.Text = result;
            }


        }

       private void ClearForm ()
        {
            NameText.Text = "";
            AgeText.Text = "";
            RegText.Text = "";
            AddressText.Text = "";
            DeptText.Text = "";
        }
        private void LoadStudents()
        {
            StudentGridView.DataSource = studentManager.GetAllStudents();
            StudentGridView.DataBind();
        }
        //private void GetCreatedStudent()
        //{
        //    StudentGridView.DataSource = studentManager.GetAllStudents();
        //    StudentGridView.DataBind();
        //}

    }
}