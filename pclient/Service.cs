using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public void register(string s1, string s2, string s3, string pname, string password)
    {

        //DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "insert into users(student1id,student2id,student3id,projectname,password)values(@s1,@s2,@s3,@pname,@pass)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@s1", s1);
            cmd.Parameters.AddWithValue("@s2", s2);
            cmd.Parameters.AddWithValue("@s3", s3);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pass", password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //   SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            //  sda.Fill(ds, "register");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
    public bool login(string s1, string password)
    {
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT student1id,password from users where student1id=@s1 and password=@s2";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@s1", s1);
            cmd.Parameters.AddWithValue("@s2", password);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

    }
    public bool flogin(string s1, string password)
    {
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT uname,password from Faculty where uname=@s1 and password=@s2";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@s1", s1);
            cmd.Parameters.AddWithValue("@s2", password);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

    }
    public void projectdetail(string filename, string description, string subdate, string approve, int uid, string tid)
    {
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "insert into projectdata(filename,description,subdate,approve,uid,tid)values(@s1,@s2,@s3,@s4,@s5,@s6)";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@s1", filename);
            cmd.Parameters.AddWithValue("@s2", description);
            cmd.Parameters.AddWithValue("@s3", subdate);
            cmd.Parameters.AddWithValue("@s4", approve);
            cmd.Parameters.AddWithValue("@s5", uid);
            cmd.Parameters.AddWithValue("@s6", tid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
    public string getuser(string a)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string Query = "SELECT * from users where student1id=@s1";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.Parameters.AddWithValue("@s1", a);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        string x = "";
        if (rdr.Read())
        {
            x = rdr["id"].ToString();
        }
        con.Close();
        return x;
    }
    public string getusername(string a)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string Query = "SELECT * from users where id=@s1";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.Parameters.AddWithValue("@s1", a);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        string x = "";
        string y = " ";
        if (rdr.Read())
        {
            x = rdr["student1id"].ToString();
            y = rdr["projectname"].ToString();
        }
        con.Close();
        return x + " " + y;
    }
    public string gettask(string a)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string Query = "SELECT * from task where id=@s1";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.Parameters.AddWithValue("@s1", a);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        string x = "";
        if (rdr.Read())
        {
            x = rdr["name"].ToString();
        }
        con.Close();
        return x;
    }

    public string getfaculty(string a)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string Query = "SELECT * from Faculty where uname=@s1";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.Parameters.AddWithValue("@s1", a);
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        string x = "";
        if (rdr.Read())
        {
            x = rdr["id"].ToString();
        }
        con.Close();
        return x;
    }

    public DataTable getprojectdata(int a)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string Query = "SELECT * from projectdata where id=@s1";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.Parameters.AddWithValue("@s1", a);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;

    }
    public DataSet getproject()
    {


        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM projectdata";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "projectdata");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public DataSet getdetailproject(int a)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM projectdata where id=" + a;
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "projectdata");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public void updateprojectdata(string approve, string uid, string fid, string tid)
    {
        string today = DateTime.Today.ToString("dd/MM/yyyy");
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string query = "update projectdata set apprdate=@today,approve=@approve,fid=@fid where uid=@uid AND tid=@tid";
        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.Add("@today", SqlDbType.VarChar).Value = today;
        cmd.Parameters.Add("@approve", SqlDbType.VarChar).Value = approve;
        cmd.Parameters.Add("@fid", SqlDbType.VarChar).Value = fid;
        cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;
        cmd.Parameters.Add("@tid", SqlDbType.VarChar).Value = tid;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public bool taskuploaded(string uid, string tid)
    {
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT * from projectdata where uid=@s1 and tid=@s2";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@s1", uid);
            cmd.Parameters.AddWithValue("@s2", tid);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }
    }
    public DataSet getupdateddata(int uid,int tid)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
            string Query = "SELECT * FROM projectdata where uid=" + uid + "AND tid="+tid;
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.Fill(ds, "projectdata");
        }
        catch (FaultException fex)
        {
            throw new FaultException<string>("Error: " + fex);
        }

        return ds;
    }
    public void updatepuser(string uid, string tid, string fname, string description)
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=myproject;Integrated Security=True;Pooling=False");
        string query = "update projectdata set filename=@fname,description=@description where uid=@uid AND tid=@tid";
        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
        cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;
        cmd.Parameters.Add("@tid", SqlDbType.VarChar).Value = tid;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}


