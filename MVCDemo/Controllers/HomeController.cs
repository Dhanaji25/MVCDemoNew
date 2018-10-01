using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(addModel model)
        {
            addModel mod = new addModel();
            if (ModelState.IsValid)
            {
                mod.inputOne = model.inputOne;
                mod.inputTwo = model.inputTwo;
                mod.result= model.inputOne + model.inputTwo;
            }
            return View(mod);

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
    }
}