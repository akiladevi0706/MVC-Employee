using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task21.Models;

namespace Task21.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();

            return View(employees);
        }

        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "John",
                Gender = "Male",
                City = "London"
            };

            return View();
        }



    }
}
