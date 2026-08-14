using System;
using System.Web.UI;

namespace SimpleWebpage
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "abc" && TextBox2.Text == "1234")
            {
                Label3.Text = "Login Successful....";
            }
            else
            {
                Label3.Text = "Invalid Information";
            }
        }

    }
}