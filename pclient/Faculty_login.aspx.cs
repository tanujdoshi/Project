using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class Faculty_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            bool l = client.flogin(TextBox1.Text, TextBox2.Text);
            if (l)
            {
                Session["fid"] = TextBox1.Text;
                Response.Redirect("project_list.aspx");
            }
            else
            {
                Label1.Text = "Invalid username or password";
            }
        }
    }
    }
