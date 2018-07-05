using System;
using System.Web.Mvc;
using MainCalculator.TwoArgument.TwoTwoArgumentsFactory;    
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multi", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Div", Text ="Div"
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
        public ActionResult Index(double firstValue, double secondValue, string operation)
        {
            ITwoArgumentCalculator calculator = TwoTwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue, secondValue);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multi", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Div", Text ="Div"
                }
            };
            return View();
        }
    }
}