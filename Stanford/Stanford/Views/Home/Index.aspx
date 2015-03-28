<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>斯坦福测验</title>
</head>
<body>
    <h2>斯坦福测验</h2>
    <div>
        <%=Html.ActionLink("测试", "Test")%>
    </div>
</body>
</html>
