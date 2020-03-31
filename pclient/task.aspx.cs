using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class task : System.Web.UI.Page
    {
        string a,b;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            a = Request.QueryString["id"];
            b = Session["id"].ToString();
            string uid = client.getuser(b);
           
            if (client.taskuploaded(uid, a))
            {
                Session["tid"] = a;
                Response.Redirect("updatetask.aspx");
            }
            else
            {
                Label1.Text = client.gettask(a);
                Label2.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            if (FileUpload1.HasFile)
            {
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + FileUpload1.FileName);
            }
            int uid = Int32.Parse(client.getuser(b));
            client.projectdetail(FileUpload1.FileName, TextBox1.Text, Label2.Text, "PENDING", uid, a);
            
        }
    }
}