using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class EnvironmentController : Controller
    {
        // GET: Environment
        public ActionResult Index()
        {
            ViewBag.Variables = System.Environment.GetEnvironmentVariables();
            return View();
        }
    }
}
