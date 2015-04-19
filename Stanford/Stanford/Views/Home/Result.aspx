<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<%@ Import Namespace="System.Text" %>
<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Result</title>
    <link href="../../Css/result.css" rel="stylesheet" />
</head>
<body>
    <h2>FormResults</h2>
    <div>
        <p>
            测试结果 : <b><%= Html.Encode(ViewData["type"]) %></b>
        <p />
        <div class="character">
            <div>
                <p>共同特征 : </p>
                <pre> <%= Server.HtmlDecode(Html.Encode(ViewData["description"])) %></pre>
            </div>

            <div>
                <p>适合领域 : </p>
                <pre> <%= Server.HtmlDecode(Html.Encode(ViewData["area"])) %></pre>
            </div>

            <div>
                <p>适合职业 : </p>
                <pre><%= Server.HtmlDecode(Html.Encode(ViewData["job"])) %></pre>
            </div>
        </div>
    </div>

</body>
</html>
