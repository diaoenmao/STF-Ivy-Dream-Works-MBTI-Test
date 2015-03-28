using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanford.Models;
using System.Web.Script.Serialization;
namespace Stanford.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        List<Question> questionList = new List<Question>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewData["Message"] = "斯坦福测试";

            return View();
        }

        public JsonResult Question()
        {
            questionList.Add(new Question("当你要外出一整天，你会", "计划你要做什么和在什么时候做", "说去就去"));
            questionList.Add(new Question("你认为自己是一个", "较为随兴所至的人", "较为有条理的人"));
            return this.Json(questionList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Result(string favColor)
        {
            ViewData["favColor"] = favColor;
            //ViewData["bookType"] = bookType;
            //ViewData["pet"] = pets;

            return View("Result");
        }
    }
}
