using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Papa.Areas.AdminPages.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /AdminPages/Deafault/
        public ActionResult Index()
        {
            return View();
        }
	}
}