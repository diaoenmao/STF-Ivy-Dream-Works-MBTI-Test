<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>

<script type="text/javascript" src="js/script.js"></script>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>
<body>

<h2><%= Html.Encode(ViewData["Message"]) %></h2>


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