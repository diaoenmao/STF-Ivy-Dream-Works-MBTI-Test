<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

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
        <p>测试结果 : <b><%= Html.Encode(ViewData["type"]) %></b><p/>
        <div class =" character">
            <p>
                <pre>共同特征 : <%= Server.HtmlDecode(Html.Encode(ViewData["description"])) %></pre>
                <pre>适合领域 :   </pre>
            </p>
        </div>
    </div>

</body>
</html>
