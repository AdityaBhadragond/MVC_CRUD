using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                List<Employee> emplist = db.Employees.ToList<Employee>();
                return Json(new { data = emplist },JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult AddorEdit()
        {
            return View();
        }
    }
}