using shuli_blog.DAL;
using shuli_blog.Models;
using shuli_blog.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class BlogPageController : Controller
    {

        FanService service = new FanService();
        
        public ActionResult Index()
        {
            Fan fan = service.create("john", "cena", DateTime.Parse("2004-02-04"), 6);
            service.details(fan);
            Fan fan2 = service.index(3);
            service.details(fan2);
            List<Fan> list = service.list();
            Boolean boo = service.delete(fan2);
            return View();  
        }

    }
}
