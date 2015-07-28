using Store.Domain;
using Store.Infrastructure.DataSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Infrastructure.WEbUI.Controllers
{
    public class UsersController : Controller
    {
        UserRepository userRepository = new UserRepository();
        
        // GET: Users
        public ActionResult Index()
        {

            return View();
        }

        public  ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
          

            if (ModelState.IsValid)
            {
                user.DateCreated = DateTime.Now;
                userRepository.Create(user);
                return RedirectToAction("Index","Home");
            }

            return View();
        }
    }
}