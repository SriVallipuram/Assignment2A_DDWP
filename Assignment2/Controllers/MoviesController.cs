using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your Movie description page.";
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Movie Creation Page.";
            return View();
        }
    }
}