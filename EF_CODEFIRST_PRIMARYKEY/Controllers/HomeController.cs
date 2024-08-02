using EF_CODEFIRST_PRIMARYKEY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CODEFIRST_PRIMARYKEY.Controllers
{
    public class HomeController : Controller
    {
        DataContext db= new DataContext();  
        public ActionResult Index()
        {
            var data= db.Employees.ToList();
            return View(data);
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