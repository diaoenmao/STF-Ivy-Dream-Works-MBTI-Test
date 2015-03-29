<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<body>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Result</title>
</head>

<h2>FormResults</h2>
<p>
Your choise: <b><%= Html.Encode(ViewData["choice"]) %></b>
</p>

<%--<% if (ViewData["bookType"].Equals(true))
   { %>
<p>You read more <b>fiction</b> than non-fiction.</p>
<% }
   else
   { %>
<p>You read more <b>non-fiction</b> than fiction.</p>
<% } %>
Your favorite pet: <b><%= Html.Encode(ViewData["pet"]) %></b>--%>
</body>
</html>