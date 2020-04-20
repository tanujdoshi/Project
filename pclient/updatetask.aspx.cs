using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class updatetask : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
        string uid, tid,app,fname;

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            if (app == "NO" || app == "PENDING")
            {
                if (FileUpload1.HasFile)
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + FileUpload1.FileName);
                }
                //Label16.Text = uid + " " + tid + " " + FileUpload1.FileName + " " + TextBox1.Text;
                client.updatepuser(uid, tid, FileUpload1.FileName, TextBox1.Text);
                Label15.Text = "Task Uploaded Successfully!!";
            }
            else
            {
                Label11.Text = "You Can't update once it is approved!!";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label11.Text = "";
            Label15.Text = " ";
            Label1.Text = Session["id"].ToString();
            tid = Session["tid"].ToString();
            string u = Session["id"].ToString();
            uid = ser.getuser(u);
            //  Response.Write(id);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
       
               ds = ser.getupdateddata(Int32.Parse(uid), Int32.Parse(tid));
               dt = ds.Tables["projectdata"];

               foreach (DataRow dr in dt.Rows)
               {
                   Label3.Text = ser.gettask(dr["tid"].ToString());
                   tid = dr["tid"].ToString();
                fname = dr["filename"].ToString();
                Label4.Text = " <a href=\"download.aspx?name=" + dr["filename"] + "\">"+ dr["filename"] + " </a> ";
                   //"< a href = '" + "download.aspx?name=" + dr["filename"] + "' > " + "  " + dr["filename"].ToString() + " </ a > ";
                   Label5.Text = dr["description"].ToString();
                TextBox1.Text = dr["description"].ToString();
                Label2.Text = dr["subdate"].ToString();

                   string s = ser.getusername(dr["uid"].ToString());
                   string[] commands = s.Split(' ');
                   Label8.Text = commands[1];
                   Label7.Text = commands[0];
                   uid = dr["uid"].ToString();

                   Label6.Text = dr["apprdate"].ToString();
                Label9.Text = dr["fid"].ToString();
                Label10.Text = dr["approve"].ToString();
                app= dr["approve"].ToString();
            }
      }


       
    }
}
