using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stanford.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            List<string> petList = new List<string>();
            petList.Add("Dog");
            petList.Add("Cat");
            petList.Add("Hamster");
            petList.Add("Parrot");
            petList.Add("Gold fish");
            petList.Add("Mountain lion");
            petList.Add("Elephant");

            ViewData["Pets"] = new SelectList(petList);
            return View();
        }

        public ActionResult HandelForm(string name, string favColor, Boolean bookType, string pets)
        {
            ViewData["name"] = name;
            ViewData["favColor"] = favColor;
            ViewData["bookType"] = bookType;
            ViewData["pet"] = pets;

            return View("Result");
        }
    }
}
