using BeautyStoreOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautyStoreOnline.Controllers
{
    public class HomeController : Controller
    {
        DBBeautyStoreOnlineEntities1 db = new DBBeautyStoreOnlineEntities1();
        public ActionResult Index()
        {
            ViewBag.ProductList = db.Products.ToList().Take(10);
            return View();
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