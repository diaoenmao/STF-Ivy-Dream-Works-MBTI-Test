<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>斯坦福测验</title>
    <meta name="description" content="斯坦福测验" />
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8">
	<meta content="always" name="referrer">
    <link href="../../Css/ooo.css" rel="stylesheet" />
</head>

<body>



    <div class="description">
        <h1>尊敬的学员</h1>
        <h1>欢迎您进行STF斯坦福职业性格测试</h1>

        <p style="font-family: 'Microsoft YaHei'">STF斯坦福职业性格测试作为一种对个性的判断和分析工具，实在国际最为流行的职业性格评估工具的基础上进行调整和改进，旨在从纷繁复杂的个性特征中，归纳提炼出关键要素的——动力、信息收集、决策方式、生活方式，进行分析判断，从而把不同个性的人区别开来</p>

        <ul>
            <p>它的应用领域包括</p>
            <li>
                <p>自我了解和发展</p>
            </li>

            <li>
                <p>职业发展和规划</p>
            </li>

            <li>
                <p>组织发展</p>
            </li>

            <li>
                <p>团队建设</p>
            </li>

            <li>
                <p>管理和领导能力培训</p>
            </li>

            <li>
                <p>解决问题能力</p>
            </li>

            <li>
                <p>情感问题咨询</p>
            </li>

            <li>
                <p>教育和学校科目的发展</p>
            </li>

            <li>
                <p>多样性和多元文化性培训</p>
            </li>
            <li>
                <p>学术咨询</p>
            </li>
        </ul>
    </div>
    <div>
        <%=Html.ActionLink("测试", "Test")%>
    </div>
</body>
</html>
