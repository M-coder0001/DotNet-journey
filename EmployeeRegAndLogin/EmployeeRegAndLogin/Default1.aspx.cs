using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeRegAndLogin
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BLACK13\\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from registration where username=@username and password=@password", con);

            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                Label1.Text = "Login Successful...";
            else
                Label1.Text = "Invalid info...";
        }
    }
}