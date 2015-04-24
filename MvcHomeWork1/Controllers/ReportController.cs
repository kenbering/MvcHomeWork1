using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomeWork1.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        public ActionResult Index()
        {
            using(var db = new CustomerEntities())
            {
                var temp = from p in db.Report_vw
                           select p;
                return View(temp.ToList());
            }
        }

       

    }
}
