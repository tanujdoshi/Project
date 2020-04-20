<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatetask.aspx.cs" Inherits="pclient.updatetask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

    <title></title>
</head>
<body>
  
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
        
      <li class="nav-item">
        <a class="nav-link" href="home.aspx">Home</a></li>
        <li class="nav-item">
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      </li>
        
      <li class="nav-item">
        <a class="nav-link" href="logout.aspx">Logout</a>
    </ul>
  </div>
</nav>

    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label11" runat="server" Font-Italic="True" Text="You have already uploaded Your Task" ForeColor="#FF3300"></asp:Label>
            <br />
            <br />
            <table class="table">
                <tr>
                    <td>Project Name</td>
                    <td>
                            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Task Name</td>
                    <td>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>File</td>
                    <td>
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Breif Description</td>
                    <td>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>submit date</td>
                    <td>
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Approved?</td>
                    <td>
                            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Approve Date</td>
                    <td>
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Student Leader Id</td>
                    <td>
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td>Faculty Name</td>
                    <td>
                            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td><h3>Update Your Task!!</h3></td>
                </tr>
                <tr>
                    <td>File</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Breif Description</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Update" />
                    </td>
                    <td>
            <asp:Label ID="Label15" runat="server" Text="Label" ForeColor="#00CC00"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
