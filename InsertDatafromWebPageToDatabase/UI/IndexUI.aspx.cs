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
                LoadStudents();          
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = NameText.Text;
            student.Age = Convert.ToInt32(AgeText.Text);
            student.Depertment = DeptText.Text;
            student.RegNo = RegText.Text;
            student.Address = AddressText.Text;
            
           OutputLabel.Text=studentManager.SaveStudent(student);
            ClearForm();
            LoadStudents();
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
    }
}