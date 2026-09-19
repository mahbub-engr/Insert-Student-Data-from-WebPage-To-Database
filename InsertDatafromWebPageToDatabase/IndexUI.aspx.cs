using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsertDatafromWebPageToDatabase
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = NameText.Text;
            student.Age = Convert.ToInt32(AgeText.Text);
            student.Depertment = DeptText.Text;
            student.RegNo = RegText.Text;
            student.Address = Address.Text;
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
            if (res>0)
            {
                OutputLabel.Text = "Save Successfully";
            }
            else
            {
                OutputLabel.Text = "Failed to Save ";
            }
            NameText.Text = "";
            AgeText.Text = "";
            RegText.Text = "";
            AddressText.Text = "";
            DeptText.Text = "";
        }
    }
}