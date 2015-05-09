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

    <div onmousedown ="hideAll();" style="position: absolute; height:100%; width: 100%; background-color:transparent; z-index : -1"></div>

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

    <!-- TEMPLATE FOR A JOB
    <div id="job1" class="job" onmousedown="showMajor(true, 'job1');" runat="server">
        111
    </div>
     -->

    <form id= "jobForm" action="/Home/Result/Major" method="post">
        Major selected : <input id="majorSelected" type="text" name="majorSelected" value="">
    </form>


    <!-- these divs will be created dynamicly -->
    <div class="major" id="major_div" style="visibility: hidden; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <div id="major" onmouseover="showUniv(true, 'major');" style= "position: relative; left: 10px; top: 25px" runat="server">
            I selected <pre><%= Server.HtmlDecode(Html.Encode(ViewData["major"])) %></pre>
        </div>
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>



    <div class="university" id="univ_div" style="visibility: hidden; width: 200px; height: 200px; margin: 0px, 0px, 0px, 0px" runat="server">
        <img src="../../Pictures/dialogbox.png" style="width: 200px; height: 200px; filter: alpha(opacity=40);" runat="server">
    </div>



   
    <script>
        function showMajor(display, jobId) {
            if (display) {
                document.getElementById('major_div').style.visibility = 'visible';

                var jobDiv = document.getElementById(jobId);
                //set input value
                var input = document.getElementById("majorSelected");
                input.value = jobId;
                //submit job form
                var jobForm = document.getElementById("jobForm");
                jobForm.submit();

                var majorDiv = document.getElementById('major_div');
                var rect = jobDiv.getBoundingClientRect();

                majorDiv.style.left = (rect.left + 10)+'px';
                majorDiv.style.top = (rect.top + 10)+'px';
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

    
    



</body>
</html>
