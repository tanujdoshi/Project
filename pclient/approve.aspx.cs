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
        public List<List<string>> myList;
        public DataSet ds;
        public DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
             ds = new DataSet();
             dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getproject();
            dt = ds.Tables["projectdata"];
          
         //   Response.Write("<table border=1><tr><td>No</td><td>File Name</td><td>Task</td></tr>");


            myList = new List<List<string>>();
            foreach (DataRow dr in dt.Rows)
                {
                     //   Response.Write("<tr>");
                
                if ((dr["uid"]).ToString() == Request.QueryString["id"] && (dr["approve"].ToString() == "PENDING" || dr["approve"].ToString() == "NO"))
                {
                    string x = ser.gettask(dr["tid"].ToString());

                    //Response.Write("\n" + "<hr/>"   +  dr["tid"].ToString() +  "  " + dr["filename"].ToString() + "  " +"<a href='" + "detailapprove.aspx?id=" + dr["id"] + "'>" +  x +"</a>" + "\t");
               //     Response.Write("<td>"+ dr["tid"].ToString() + "</td>");
               //     Response.Write("<td>" + dr["filename"].ToString() + "</td>");
               //     Response.Write("<td>" + "<a href='" + "detailapprove.aspx?id=" + dr["id"] + "'>" + x + "</a>" + "</td>");
                    //   Response.Write("<input type=\"button\" value=\"OK\" onclick=\"javascript:window.location.href='order.aspx?oid=" + dr["oid"] + "'\" />");
                    myList.Add(new List<string> { dr["tid"].ToString(), dr["filename"].ToString(),x+" "+dr["id"] });

                }
               // Response.Write("</tr>");
            }
            //Response.Write("</table>");

        }

    }
}
