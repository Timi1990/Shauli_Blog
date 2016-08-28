using shuli_blog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class FanPageController : Controller
    {
        private FanContext fanContext = new FanContext();

        public ActionResult Index()
        {
            return View();    
        }

    }
}
