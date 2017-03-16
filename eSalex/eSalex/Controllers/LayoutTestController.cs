using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSalex.Controllers
{
    public class LayoutTestController : Controller
    {
        // GET: LayoutTest
        public ActionResult Index()
        {
            ViewBag.test = "1";
            return View();
        }

        public ActionResult TestPartial()
        {
            return PartialView("_SysDatePartial");
        }
    }
}