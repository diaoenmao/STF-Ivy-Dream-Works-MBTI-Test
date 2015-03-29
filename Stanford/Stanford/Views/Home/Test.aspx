<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
    <script src="<%= Url.Content("~/Scripts/MicrosoftAjax.debug.js") %>" 
		type="text/javascript"></script>  
    <script src="<%= Url.Content("~/Scripts/MicrosoftMvcAjax.debug.js") %>" 
		type="text/javascript"></script>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>
<body>

<h2><%= Html.Encode(ViewData["Message"]) %></h2>

<form action="/Home/Result" method="post">
    <%=ViewData["Q"]%><br />
    <input type="radio" name="choice" value="A"><%=ViewData["A"]%><br />
    <input type="radio" name="choice" value="B"><%=ViewData["B"]%><br />
    <br /><br />
    <input type="submit" value="下一题" />
</form> 

</body>
</html>