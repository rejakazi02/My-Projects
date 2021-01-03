using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOLETApp.Models;
using TOLETApp.ViewModels;

namespace TOLETApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            IndexVm indexVm = new IndexVm();
            var tolet = db.ToLetPublishs.ToList();
            indexVm.ToLetPublishs = tolet;

            var customers = db.Customers.ToList();
            indexVm.Customers = customers;
            return View(indexVm);
        }

       

        public ActionResult Contact()
        {
            ViewBag.Message = "This is our website contact page.";

            return View();
        } public ActionResult About()
        {
            ViewBag.Message = "This is our website description page.";

            return View();
        }
    }
}