using shuli_blog.Models;
using shuli_blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Controllers
{
    public class CommentController : Controller
    {
        private CommentService commentService = new CommentService();

        public ActionResult Create(int id , String title, String author, string website, string body)
        {
            //parse data in the comment view
            return View(commentService.create(id, title, author, website, body));
        }

    }
}
