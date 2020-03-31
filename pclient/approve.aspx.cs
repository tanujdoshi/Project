using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pclient
{
    public partial class approve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getproject();
            dt = ds.Tables["projectdata"];
            Response.Write("\n" + "NO." + "File NAME" + "Task"+"\n");

         
                foreach (DataRow dr in dt.Rows)
                {
                //        Response.Write("<img src='" + "~/images/3.jpg" + "'/>");
                if ((dr["uid"]).ToString() == Request.QueryString["id"] && dr["fid"].ToString() == "1")
                {
                    string x = ser.gettask(dr["tid"].ToString());
                    Response.Write("\n" + "<hr/>"   + "<a href='" + "detailapprove.aspx?id=" + dr["id"] + "'>" + "  " + dr["tid"].ToString() + "</a>"+ "  " + dr["filename"].ToString() + "  " + x +  "\t");
                 //   Response.Write("<input type=text value='hello'>");
                 //   Response.Write("<input type=\"button\" value=\"OK\" onclick=\"javascript:window.location.href='order.aspx?oid=" + dr["oid"] + "'\" />");

                }
            }
       

        }

    }
}
