using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MainCalculator;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiSolution", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "plusSolution", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "minSolution", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "delSolution", Text ="Div"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ITwoArgumentCalculator calculator = TwoTwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multiSolution", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "plusSolution", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "minSolution", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "delSolution", Text ="Div"
                }
            };
            return View();
        }
    }
}