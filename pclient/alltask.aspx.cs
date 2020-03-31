using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class alltask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected  void insert_click(object sender, EventArgs e)
        {
           SqlDataSource1.InsertParameters["name"].DefaultValue= ((TextBox)GridView1.FooterRow.FindControl("taskname")).Text;
            SqlDataSource1.Insert();
        }
    }
}