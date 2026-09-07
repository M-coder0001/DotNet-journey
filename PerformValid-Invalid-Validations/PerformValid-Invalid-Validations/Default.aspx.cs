using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformValid_Invalid_Validations
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime bdate;
            int days, age;

            bdate = Convert.ToDateTime(TextBox5.Text);
            days = (DateTime.Now - bdate).Days;
            age = days / 365;

            if (age >= 18)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Record Saved👌";
        }
    }
}