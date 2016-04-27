using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            /* Det finns ett sätt att förstöra denna kod och det är genom att ha mer än en fråga
            i databasen som har samma nummer. Det kraschar inte, men båda frågorna räknas.
            Säkra upp att man inte får lov att ge den samma nummer. FIXAT med annnotations (tror jag)*/

            FormScore score = new FormScore();
            List<Question> questions = new List<Question>();

            using (QuestionContext context = new QuestionContext())
            {
                questions = context.Questions.ToList();
            }
            //En lista för att spara numret på alla frågor som man svarat ja på
            List<int> yesQuestions = new List<int>();

            if (Request["submit"] != null)
            {
                //Ger en collection med key-value pairs
                var x = Request.Form;

                //Går igenom collectionen
                //om value är 1 (dvs. "ja"), lägg till i listan med frågor som ska räknas
                foreach (string key in x)
                {
                    var value = x[key];

                    if (value == "1")
                    {
                        yesQuestions.Add(int.Parse(key));
                    }

                }

                //Går igenom den lokala listan med frågor, räknar ihop poängen på alla frågor
                //vars nummer finns i listan yesQuestions
                foreach (Question q in questions)
                {
                    if (yesQuestions.Contains(q.QuestionNumber))
                    {
                        score.ScoreA += q.ScoreA;
                        score.ScoreB += q.ScoreB;
                        score.ScoreC += q.ScoreC;
                    }
                }

                ViewBag.Score = score;
               
            }

            return View(questions);
        }
    }
}