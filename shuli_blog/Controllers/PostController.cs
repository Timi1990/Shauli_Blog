using shuli_blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class PostController : Controller
    {
        private PostService postService = new PostService();

        public ActionResult SearchPost(){
            return View();
        }

        public ActionResult SearchResult()
        {
            return View();
        }

    }
}
