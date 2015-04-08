<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Result</title>
</head>
<body>
<h2>FormResults</h2>
<p>
你的性格类型: <b><%= Html.Encode(ViewData["type"]) %></b><br />
特征: <br /><b><%= Server.HtmlDecode(Html.Encode(ViewData["description"])) %></b>
</p>

</body>
</html>