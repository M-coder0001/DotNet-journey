using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox_AND_BulletedList
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Insert(int.Parse(TextBox2.Text), TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(TextBox1.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Add(TextBox1.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Insert(int.Parse(TextBox2.Text), TextBox1.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Remove(TextBox1.Text);
        }
    }
}