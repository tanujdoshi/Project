<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detailapprove.aspx.cs" Inherits="pclient.detailapprove" %>

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
        <a class="nav-link" href="project_list.aspx">Home</a></li>  
      <li class="nav-item">
        <a class="nav-link" href="alltask.aspx">All Tasks</a>
       </li>
      <li class="nav-item">
        <a class="nav-link" href="logout.aspx">Logout</a>
       </li>
    </ul>
  </div>
</nav>

    <form id="form1" runat="server" align="center">
        <div class="form-group">
            
            <table class="table">
                <tr>
                    <td colspan="2"><h3>Approve Task</h3></td>
                 </tr>
                <tr>
                    <td>Project Name</td>
                    <td>
                        <asp:Label ID="Label8" class="form-control" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Task Name</td>
                    <td>
                        <asp:Label ID="Label3" class="form-control" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>File</td>
                    <td>
                        <asp:Label ID="Label4" class="form-control" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Breif Description</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" class="form-control" TextMode="MultiLine" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Submit Date</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Approved ?</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>YES</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Approve date</td>
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
                    <td>
                        Faculty Name:</td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
