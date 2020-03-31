using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome" + Session["id"];
          /*  ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            DropDownList1.DataSource = client.gettasks();
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("please select"));*/
           // string country = (e.Item.DataItem as DataRowView)["Country"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = DropDownList1.SelectedItem.Value;
            Response.Redirect("task.aspx?id=" + x);
         

        }
    }
}