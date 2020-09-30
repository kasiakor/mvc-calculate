using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 20;
            int result = firstVal / secondVal;

            ViewBag.Message = "Welcome to my page";
            return View(result);
        }
    }
}