<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>
<body>

<h2><%= Html.Encode(ViewData["Message"]) %></h2>



<form action="/Home/Result" method="post">
    <ol>
 <% var V = Model;
    var i = 1;%>
        <% foreach (var Question in V)
{ %>     
    <li>
    <%=Question.Q%><br />
    <input type="radio" name="q<%=i%>" value="0"><%=Question.A%>
    <input type="radio" name="q<%=i%>" value="1"><%=Question.B%><br />
    <br />
    </li>
    <%  i = i +1;%>
        <%} %>
    </ol>
   <input type="submit" value="提交" />
 </form>

</body>
</html>