using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanford.Models;
using Stanford.Context;
namespace Stanford.Controllers
{
    public class HomeController : Controller
    {



        QuestionContext questionDb = new QuestionContext();
        //
        // GET: /Home/
        QuestionList questionList = new QuestionList();
        AnswerList answerList = new AnswerList();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewData["Message"] = "斯坦福测试";

            return View(questionDb.Questions.ToList());

            //return View(questionList.getList().ToList());
        }

        public ActionResult Result(
            string q1, string q2, string q3, string q4,
            string q5, string q6, string q7, string q8,
            string q9, string q10, string q11, string q12,
            string q13, string q14, string q15, string q16,
            string q17, string q18, string q19, string q20,
            string q21, string q22, string q23, string q24,
            string q25, string q26, string q27, string q28,
            string q29, string q30, string q31, string q32,
            string q33, string q34, string q35, string q36,
            string q37, string q38, string q39, string q40,
            string q41, string q42, string q43, string q44,
            string q45, string q46, string q47, string q48,
            string q49, string q50, string q51, string q52,
            string q53, string q54, string q55, string q56,
            string q57, string q58, string q59, string q60,
            string q61, string q62, string q63, string q64,
            string q65, string q66, string q67, string q68,
            string q69, string q70, string q71, string q72,
            string q73, string q74, string q75, string q76,
            string q77, string q78, string q79, string q80,
            string q81, string q82, string q83, string q84,
            string q85, string q86, string q87, string q88,
            string q89, string q90, string q91, string q92,
            string q93)
        {
            answerList.add(q1); answerList.add(q2); answerList.add(q3); answerList.add(q4);
            answerList.add(q5); answerList.add(q6); answerList.add(q7); answerList.add(q8);
            answerList.add(q9); answerList.add(q10); answerList.add(q11); answerList.add(q12);
            answerList.add(q13); answerList.add(q14); answerList.add(q15); answerList.add(q16);
            answerList.add(q17); answerList.add(q18); answerList.add(q19); answerList.add(q20);
            answerList.add(q21); answerList.add(q22); answerList.add(q23); answerList.add(q24);
            answerList.add(q25); answerList.add(q26); answerList.add(q27); answerList.add(q28);
            answerList.add(q29); answerList.add(q30); answerList.add(q31); answerList.add(q32);
            answerList.add(q33); answerList.add(q34); answerList.add(q35); answerList.add(q36);
            answerList.add(q37); answerList.add(q38); answerList.add(q39); answerList.add(q40);
            answerList.add(q41); answerList.add(q42); answerList.add(q43); answerList.add(q44);
            answerList.add(q45); answerList.add(q46); answerList.add(q47); answerList.add(q48);
            answerList.add(q49); answerList.add(q50); answerList.add(q51); answerList.add(q52);
            answerList.add(q53); answerList.add(q54); answerList.add(q55); answerList.add(q56);
            answerList.add(q57); answerList.add(q58); answerList.add(q59); answerList.add(q60);
            answerList.add(q61); answerList.add(q62); answerList.add(q63); answerList.add(q64);
            answerList.add(q65); answerList.add(q66); answerList.add(q67); answerList.add(q68);
            answerList.add(q69); answerList.add(q70); answerList.add(q71); answerList.add(q72);
            answerList.add(q73); answerList.add(q74); answerList.add(q75); answerList.add(q76);
            answerList.add(q77); answerList.add(q78); answerList.add(q79); answerList.add(q80);
            answerList.add(q81); answerList.add(q82); answerList.add(q83); answerList.add(q84);
            answerList.add(q85); answerList.add(q86); answerList.add(q87); answerList.add(q88);
            answerList.add(q89); answerList.add(q90); answerList.add(q91); answerList.add(q92);
            answerList.add(q93);
            AnswerProcessor processor = new AnswerProcessor();
            List<String> output = processor.process(answerList);
            ViewData["type"] = output[0];
            ViewData["description"] = output[1];
            ViewData["area"] = output[2];
            ViewData["job"] = output[3];
            ViewData["major"] = output[4];
            return View("Result");
        }
        // <form action="/Home/new" method="post">  public ActionResult new(

    }
}
