using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSForm.Models;

namespace AngularJSForm.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Error(string error)
        {
            return View(new ErrorModel() { ErrorString = error });
        }
    }
}
