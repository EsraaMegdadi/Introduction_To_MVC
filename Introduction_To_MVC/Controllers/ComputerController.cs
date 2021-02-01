using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introduction_To_MVC.Models;

namespace Introduction_To_MVC.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
        public ActionResult Display()
        {
            var myComputer = new Computer
            {
                Name = "lenovo",
                price = 1570
            };
            return View(myComputer);
        }
    }
}