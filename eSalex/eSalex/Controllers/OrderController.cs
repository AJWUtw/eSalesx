using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSalex.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //var order = orderService.GetOrderById("87");
            //ViewBag.CustId = order.CustId;
            //ViewBag.CustName = order.CustName;

            //ViewBag.Desc = "我是 ViewBag";
            //ViewData["Desc2"] = "我是 ViewData";
            //TempData["Desc2"] = "我是 TempData";
            
            return View();
        }

        public ActionResult InsertOrder()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            //Models.OrderService orderService = new Models.OrderService();
            //orderService.InsertOrder(order);
            //return View("Index");
            ViewBag.Desc = "我是 ViewBag";
            ViewData["Desc2"] = "我是 ViewData";
            TempData["Desc2"] = "我是 TempData";
            return RedirectToAction("Index");
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "87";
            //result.CustName = "魯蛋";

            var result = new Models.Order() { CustId = "87", CustName = "魯蛋" };

            return this.Json(result,JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetOrderList()
        {
            Models.OrderService orderservice = new Models.OrderService();
            ViewBag.Data = orderservice.GetOrderByCondition();
            return View();
        }

        public ActionResult GetDropDownList()
        {
            List<SelectListItem> custData = new List<SelectListItem>();
            custData.Add(new SelectListItem() {
                Text = "王小明",
                Value = "1"
            });
            custData.Add(new SelectListItem()
            {
                Text = "王大明",
                Value = "2"
            });
            ViewBag.custData = custData;
            return View();
        }
    }
}