using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	//registration
	[OperationContract]
	 void register(string s1, string s2, string s3, string pname, string password);
	//student login
	[OperationContract]
	bool login(string s1, string password);
	//faculty login
	[OperationContract]
	bool flogin(string s1, string password);
	//insert project details
	[OperationContract]
	void projectdetail(string filename, string description, string subdate, string approve, int uid, string tid);
	[OperationContract]
	string getuser(string a);

	//get project data
	[OperationContract]
	DataTable getprojectdata(int a);
	[OperationContract]
	DataSet getproject();
	[OperationContract]
	DataSet getdetailproject(int a);
	[OperationContract]
	string gettask(string a);
	[OperationContract]
	string getfaculty(string a);
	[OperationContract]
	string getusername(string a);
	[OperationContract]
	void updateprojectdata(string approve, string uid, string fid, string tid);
	[OperationContract]
	bool taskuploaded(string uid, string tid);
	[OperationContract]
	DataSet getupdateddata(int uid, int tid);
	[OperationContract]
	void updatepuser(string uid, string tid, string fname, string description);


}
