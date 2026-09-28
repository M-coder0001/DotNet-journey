using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace EmployeeRegAndLogin
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BLACK13\\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into registration values(" +
                "'"+TextBox1.Text+ "','"+TextBox2.Text+ "'," +
                "'"+TextBox3.Text+ "','"+TextBox4.Text+"')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Registration Successful";
            con.Close();
        }
    }
}