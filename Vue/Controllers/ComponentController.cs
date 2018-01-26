using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vue.Controllers
{
    public class ComponentController : Controller
    {
        // GET: Component
        public ActionResult Header()
        {
            return View();
        }
    }
}