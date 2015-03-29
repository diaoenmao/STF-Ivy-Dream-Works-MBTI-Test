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
        QuestionList questionList = new QuestionList();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewData["Message"] = "斯坦福测试";
            ViewBag.Question = questionList;
            ViewData["Q"] = questionList.getQ(0);
            ViewData["A"] = questionList.getA(0);
            ViewData["B"] = questionList.getB(0);
            return View();
        }


        public ActionResult Result(string choice)
        {
            ViewData["choice"] = choice;
            //ViewData["bookType"] = bookType;
            //ViewData["pet"] = pets;

            return View("Result");
        }
    }
}
