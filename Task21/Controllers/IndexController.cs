using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task21.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/
        public ActionResult Index()
       {
            ViewBag.Countries = new List<string>()
                {
                    "India",
                    "US",
                    "UK",
                    "Cabada"
                };
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

    }
}
