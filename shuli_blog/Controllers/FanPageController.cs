using shuli_blog.DAL;
using shuli_blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class FanPageController : Controller
    {
        private FanService service = new FanService();

        public ActionResult Index()
        {
            return View();    
        }

    }
}
