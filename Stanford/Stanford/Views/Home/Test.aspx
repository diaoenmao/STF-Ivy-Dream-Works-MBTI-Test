<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
    <link href="../../Css/test.css" rel="stylesheet" />
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
                <p><%=Question.Q%></p>
                <div>
                    <input type="radio" name="q<%=i%>" value="0" required><%=Question.A%><br />
                    <input type="radio" name="q<%=i%>" value="1" required><%=Question.B%><br />
                </div>
            </li>
            <%  i = i + 1;%>
            <%} %>
        </ol>
        <input type="submit" value="提交" />
    </form>

</body>
</html>
