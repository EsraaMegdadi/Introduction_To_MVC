using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_To_MVC.Controllers
{
    //RoutePrefix
    [RoutePrefix("Student")]
    public class StudentController : Controller
    {
        // GET: Student
        [Route("Details/{id:int}")]
        public ActionResult Details(int id)
        {
            return Content("<h3>Student ID is </h3><h1>" + id + "</h1>");
        }

        
        [Route("Details/{name}")]
        public ActionResult Details(string name)
        {
            return Content("<h3>Student name is </h3>" + name);

        }
    }
}