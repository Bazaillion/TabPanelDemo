using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TabPanelDemo.Models;

namespace TabPanelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Tab> tabs = new List<Tab>();
            tabs = DAL.GetTabs();

            return View(tabs);
        }
    }
}