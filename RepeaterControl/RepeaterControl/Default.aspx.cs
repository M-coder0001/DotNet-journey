using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace RepeaterControl
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                SqlConnection con = new SqlConnection("Data Source=BLACK13\\SQLEXPRESS;" +
                    "Initial Catalog=view;Integrated Security=True;Encrypt=False");

                con.Open();
                SqlCommand cmd = new SqlCommand("select *from control", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

                con.Close();
            }
        }
    }
}