<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="pclient.register" %>

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
        <a class="nav-link" href="register.aspx">Register</a>
      </li>
        
      <li class="nav-item">
        <a class="nav-link" href="login.aspx">Login</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="Faculty_login.aspx">Login As Faculty</a>
      </li>
   
    </ul>
  </div>
</nav>
    <form id="form1" runat="server" align="center">
        <div class="form-group">
            <table class="table1">
                <tr>
                    <td>
                        <asp:Label ID="Label1"  runat="server" Text="Student 1 Id "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Student 2 Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" class="form-control"  runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Student 3 Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Project Title</td>
                    <td>
                        <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox5" Textmode="password" class="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Register" />

        </div>
    </form>
</body>
</html>
