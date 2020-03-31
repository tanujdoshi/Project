using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class detailapprove : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
        string id, tid, uid;
        string fid;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
          //  Response.Write(id);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
           
            ds = ser.getdetailproject(Int32.Parse(id));
            dt = ds.Tables["projectdata"];
         
            foreach (DataRow dr in dt.Rows)
            {
                Label3.Text = ser.gettask(dr["tid"].ToString());
                tid = dr["tid"].ToString();
                Label4.Text = " <a href=\"download.aspx?name="+dr["filename"]+"\"> download </a> ";
                //"< a href = '" + "download.aspx?name=" + dr["filename"] + "' > " + "  " + dr["filename"].ToString() + " </ a > ";
                Label5.Text = dr["description"].ToString();
                Label2.Text = dr["subdate"].ToString();
                
               string s = ser.getusername(dr["uid"].ToString());
                string[] commands = s.Split(' ');
                Label8.Text=commands[1];
                Label7.Text = commands[0];
                uid = dr["uid"].ToString();
                
                Label6.Text = DateTime.Today.ToString("dd/MM/yyyy");
                Label9.Text = Session["fid"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            fid = ser.getfaculty(Session["fid"].ToString());
            ser.updateprojectdata(DropDownList1.SelectedItem.Value, uid, fid, tid);
            Response.Redirect("project_lis.aspx");
            Response.Redirect("project_lis.aspx");
        }
    }
}