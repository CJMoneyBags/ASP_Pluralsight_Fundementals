using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetigViewModel();
            model.Name = name ?? "no Name";
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}