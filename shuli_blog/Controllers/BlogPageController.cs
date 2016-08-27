using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class BlogPageController : Controller
    {
        public ActionResult Index()
        {
            return View();  
        }

    }
}
