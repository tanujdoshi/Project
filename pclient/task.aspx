<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task.aspx.cs" Inherits="pclient.task" %>

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
        &nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
      </li>
        
      <li class="nav-item">
        <a class="nav-link" href="logout.aspx">Logout</a>
    </ul>
  </div>
</nav>

    <form id="form1" runat="server" class="form-group">
        <div>
            
            <table class="table">
                <tr>
                    <td>Task Name</td>
                    <td>
                        <asp:Label ID="Label1" class="form-control" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Upload Your Task</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Breif Description</td>
                    <td>
                        <asp:TextBox ID="TextBox1" class="form-conrol" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Submit Date</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" class="form-control" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Approved ?</td>
                    <td>Pending</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Submit" />
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
