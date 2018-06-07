using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcHosted_VueWebpackPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ASP.NET MVC Hosted Vue.js Webpack Template";

            ViewBag.Message = "This is rendered from an ASP.NET MVC action...";

            return View();
        }
    }
}
