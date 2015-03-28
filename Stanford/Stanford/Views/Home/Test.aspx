<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>
<body>

<h2><%= Html.Encode(ViewData["Message"]) %></h2>
<br /><br />
        <div>
        <% var V = Model; %>
        <% foreach (var a in V)
        { %>
           <b>Question:-   </b>   <%= a.Q %>
           <b>A:-</b>  <%= a.A%> <br />
           <b>B:-</b>  <%= a.B%> <br />
        <%} %>
 
 
    </div>
<form action="/Home/Result" method="post">
    Select your favorite color:<br />
    <input type="radio" name="favColor" value="Blue">Blue<br />
    <input type="radio" name="favColor" value="Purple">Purple<br />
    <input type="radio" name="favColor" value="Red">Red<br />
    <br /><br />
    <input type="submit" value="下一题" />
</form> 

</body>
</html>