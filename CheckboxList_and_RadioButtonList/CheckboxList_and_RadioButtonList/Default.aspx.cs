using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckboxList_and_RadioButtonList
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBoxList1.Items.Add(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CheckBoxList1.Items.Insert(int.Parse(TextBox2.Text), TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CheckBoxList1.Items.Remove(TextBox1.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Items.Add(TextBox3.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Items.Insert(int.Parse(TextBox4.Text), TextBox3.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Items.Remove(TextBox3.Text);
        }
    }
}