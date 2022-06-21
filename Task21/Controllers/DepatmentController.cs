using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task21.Models;

namespace Task21.Controllers
{
    public class DepatmentController : Controller
    {
        //
        // GET: /Depatment/
       
         public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList<Employee>();
            return View(employees);
        }
	}
}