<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="System.Text" %>
<!DOCTYPE html>



<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Result</title>
    <link href="../../Css/result.css" rel="stylesheet" />

    <script type="text/javascript">
        var list = new list();
        function ppp() {
            var abc = "aaaaa";
            var bbb = <%= Model.jobsStr %>;
            alert(bbb);
        }


        function submitJob(jobId) {
            var input = document.getElementById("jobSelected");
            input.value = jobId;
            var jobForm = document.getElementById("jobForm");
            jobForm.submit();
        }


        function showMajor(display, jobId) {

            if (display) {
                document.getElementById('major_div').style.visibility = 'visible';
                /*
                var iDiv = document.createElement('div');
                iDiv.textContent = "created new div";
                iDiv.draggable = true;
                document.getElementsByTagName('body')[0].appendChild(iDiv);
                */

                //set input value

                //submit job form
                var jobDiv = document.getElementById(jobId);
                var majorDiv = document.getElementById('major_div');
                var rect = jobDiv.getBoundingClientRect();

                majorDiv.style.left = (rect.left + 50) + 'px';
                majorDiv.style.top = (rect.top) + 'px';

            }
            else {
                document.getElementById('major_div').style.visibility = 'hidden';
            }
        }


        function showUniv(display, majorId) {
            if (display) {
                document.getElementById('univ_div').style.visibility = 'visible';

                var majorDiv = document.getElementById(majorId);
                var univDiv = document.getElementById('univ_div');
                var rect = majorDiv.getBoundingClientRect();

                univDiv.style.left = (rect.left + 20) + 'px';
                univDiv.style.top = (rect.top + 20) + 'px';

            }
            else {
                document.getElementById('univ_div').style.visibility = 'hidden';
            }
        }

        function hideAll() {
            showMajor(false, 'Major');
            showUniv(false);
        }
    </script>

</head>

<body>
    <div onmousedown="hideAll();" style="position: absolute; height: 100%; width: 100%; background-color: transparent; z-index: -1"></div>
    <h2>FormResults</h2>

    <form id="jobForm" action="/Home/Result" method="post">
        <input id="jobSelected" name="jobSelected"/>
    </form>





    <div id="formSection">
        <h3><%=ViewData["Message"] %></h3>
        <% using (Ajax.BeginForm(
           new AjaxOptions
           {
               HttpMethod = "post",
               InsertionMode = InsertionMode.Replace,
               UpdateTargetId = "formSection"
           }
       ))
       {%>
        <textarea name="message"></textarea>
        <input type="submit" value="Send" />
       <%}%>
    </div>
    <script src="../../Scripts/jquery.unobtrusive-ajax.min.js"></script>



    <div onmousedown="ppp();">
        123123
    </div>
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

    <!-- TEMPLATE FOR A JOB
    <div id="job1" class="job" onmousedown="showMajor(true, 'job1');" runat="server">
        111
    </div>
     -->

    <!-- these divs will be created dynamicly -->
    <div class="major" id="major_div" style="visibility: visible; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <div id="major" onmousedown="showUniv(true, 'major');" style="position: absolute; left: 10px; top: 25px" runat="server">
            <pre><%= Server.HtmlDecode(Html.Encode(ViewData["major"])) %></pre>
        </div>
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>



    <div class="university" id="univ_div" style="visibility: hidden; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>





</body>
</html>
