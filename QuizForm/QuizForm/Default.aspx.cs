using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QuizForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] q = { 
                RadioButtonList1.SelectedValue, 
                RadioButtonList2.SelectedValue, 
                RadioButtonList3.SelectedValue 
            };

            int i = 0;
            int count = 0;

            SqlConnection con = new SqlConnection("Data Source=BLACK13\\SQLEXPRESS;Initial Catalog=q2;Integrated Security=True;Encrypt=False");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT ans FROM quiz", con);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                string answer = Reader["ans"].ToString();

                if(answer == q[i])
                {
                    count++;
                }
                i++;
            }
            Label1.Text = "You have scored " + count.ToString() + " out of 3";

            con.Close();
        }
    }
}