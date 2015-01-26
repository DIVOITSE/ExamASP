using MVCShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCShop.Controllers
{
    public class HomeController : Controller
    {
        private MVCShopContext db = new MVCShopContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View((from user in db.Users orderby user.Id select user).ToList());
        }

        public ActionResult Details(int id)
        {
            //EFShopRepository repository = new EFShopRepository();
            Domain.Entities.User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
    }
}
