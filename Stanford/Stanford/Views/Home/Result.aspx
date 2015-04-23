<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>



<%@ Import Namespace="System.Text" %>
<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Result</title>
    <link href="../../Css/result.css" rel="stylesheet" />
</head>
<body onmousedown ="hideAll();">
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


    <div onmouseover="showMajor(true);" runat="server">
        111
    </div>

    <div class="major" id="major_div" style="visibility: hidden; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <div onmouseover="showUniv(true);" style= "position: relative; left: 10px; top: 25px" runat="server">
            111
        </div>
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>

    <div class="university" id="univ_div" style="visibility: hidden; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>

    
   
    <script>
        function showMajor(display) {
            if (display) {
                document.getElementById('major_div').style.visibility = 'visible';
            }
            else {
                document.getElementById('major_div').style.visibility = 'hidden';
            }
        }


        function showUniv(display) {
            if (display) {
                document.getElementById('univ_div').style.visibility = 'visible';
            }
            else {
                document.getElementById('univ_div').style.visibility = 'hidden';
            }
        }

        function hideAll() {
            showMajor(false);
            showUniv(false);
        }
    </script>

    
    



</body>
</html>
