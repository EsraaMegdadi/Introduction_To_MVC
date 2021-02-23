using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_From_Scratch.Models;

namespace MVC_From_Scratch.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            var customer = new Customer(1,"Esraa Megdadi","Irbid",25);
            return View(customer);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("DisplayCustomer");
            }
            return View(cust);

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            return View();
        }
        public ActionResult DisplayList()
        {
            return View();
        }
    }
}