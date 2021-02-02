using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_To_MVC.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        //multiple  Attribute-Based Routing
        //[Route("Car/Index")]
        [Route("myCar/Index")]
        [Route("myCar")]
        [Route("")]
        public ActionResult Index()
        
        {
            return Content("This path reached  by <h1> Attribute-Based Routing</h1> way");
        }

        //Attribute-Based Routing with parameter 
        [Route("Car/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            return Content("<h3>Car ID is </h3><h1>" + id + "</h1>");
        }

        //Routing constraints
        [Route("Car/Details/{name}")]
        public ActionResult Details(string name)
        {
            return Content("<h3>Car name is </h3>" + name);

        }

    }
}