using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMVCApplication.Controllers
{
    public class RoutesController : Controller
    {
        public ActionResult One()
        {
            return View();
        }

        public ActionResult Two(int count=1)
        {
            ViewBag.iterationCount = count;
            return View();
        }

        [Authorize]
        public ActionResult Three()
        {
            return View();
        }
    }
}
