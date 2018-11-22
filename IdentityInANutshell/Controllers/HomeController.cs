using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityInANutshell.Models;

namespace IdentityInANutshell.Controllers
{
    public class HomeController : Controller
    {
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
        
        public ActionResult NewItem()
        {
            MyDbContext ORM = new MyDbContext();
            ORM.SaveChanges();
            return View();
        }

        [Authorize]
        public ActionResult AddNewItem(Item newItem)
        {
            TestingIdentityEntities ORM = new TestingIdentityEntities();
            ORM.Items.Add(newItem);
            ORM.SaveChanges();
            return View("Index");
        }
    }
}