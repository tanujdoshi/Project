<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="approve.aspx.cs" Inherits="pclient.approve" %>

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

    <form id="form1" runat="server">
      
    </form>

    <table class="table">
        <thead>
           <tr>
            <th scope="col">#</th>
            <th scope="col">File name</th>
            <th scope="col">Task</th>
            </tr>
        </thead>
        <tbody>
            <%try
                {
                    foreach (List<string> subList in myList)
                    {
                        int i = 0;
                        %><tr><%
                                  foreach (string item in subList)
                                  {
                                      if(i==2)
                                      {
                                          string[] w = item.Split(' ');string d = w[w.Length - 1];
                                          string n=item.Substring(0, item.LastIndexOf(" ")<0?0:item.LastIndexOf(" "));
                                          %>
                                          <td><a href="detailapprove.aspx?id=<%=d %>"><%=n %></a></td>
                                           <%
                                                   }
                                                   else
                                                   {
                                                       %><td><%=item %></td><%
                                                                                   }

                                                                             i++;
                                                                               }
                                                                               
                        %></tr><%
                                  }


            %><%}
    catch (Exception) { }%>
        </tbody>
    </table>
</body>
</html>
