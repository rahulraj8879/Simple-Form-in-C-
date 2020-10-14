using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Visible = false;
            if (!IsPostBack)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedValue = "select";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label6.Visible = true;
            if(TextBox1.Text==""||TextBox2.Text==""||DropDownList1.SelectedValue=="select"|| (RadioButton1.Checked==false && RadioButton2.Checked==false)|| CheckBox1.Checked == false)
            {
                Label6.Text = "All values are required";
            }
            else
            {
                if (RadioButton1.Checked == true)
                {
                    Response.Redirect("show.aspx?name=" + TextBox1.Text + "&Address=" + TextBox2.Text + "&City=" + DropDownList1.SelectedValue + "&Gender=" + RadioButton1.Text);
                }
                else
                {
                    Response.Redirect("show.aspx?name=" + TextBox1.Text + "&Address=" + TextBox2.Text + "&City=" + DropDownList1.SelectedValue + "&Gender=" + RadioButton2.Text);
                }
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked==true)
            {
                RadioButton2.Checked = false;
            }
            else if(RadioButton2.Checked==true)
            {
                RadioButton1.Checked = false;
            }
            
                
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.Checked =false;
        }
    }
}