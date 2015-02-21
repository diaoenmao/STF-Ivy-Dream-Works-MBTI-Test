<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Test</title>
</head>

<h2>Test</h2>



<h2><%= Html.Encode(ViewData["Message"]) %></h2>
<br /><br />
<% using (Html.BeginForm("HandelForm", "Home")) %>
<% { %>
    Enter your name: <%= Html.TextBox("name") %>
    <br /><br />
    Select your favorite color:<br />
    <%= Html.RadioButton("favColor", "Blue", true) %> Blue <br />
    <%= Html.RadioButton("favColor", "Purple", false)%> Purple <br />
    <%= Html.RadioButton("favColor", "Red", false)%> Red <br />
    <%= Html.RadioButton("favColor", "Orange", false)%> Orange <br />
    <%= Html.RadioButton("favColor", "Yellow", false)%> Yellow <br />
    <%= Html.RadioButton("favColor", "Brown", false)%> Brown <br />
    <%= Html.RadioButton("favColor", "Green", false)%> Green 
    <br /><br />
    <%= Html.CheckBox("bookType") %> I read more fiction than non-fiction.<br />
    <br /><br />
    My favorite pet: <%= Html.DropDownList("pets") %>
    <br /><br />
    <input type="submit" value="Submit" />
<% } %>

</html>