using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /student/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult feedback()
        {
            return View();
        }
    }
}