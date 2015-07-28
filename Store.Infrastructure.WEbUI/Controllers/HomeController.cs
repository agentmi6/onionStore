using Store.Infrastructure.DataSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Infrastructure.WEbUI.Controllers
{
    public class HomeController : Controller
    {

        UserRepository userRepository = new UserRepository();

        public ActionResult Index()
        {          

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