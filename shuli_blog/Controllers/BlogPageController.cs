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

        //FanService service = new FanService();
        private PostService postService = new PostService();
        private BloggingContext db = new BloggingContext();

        
        public ActionResult Index()
        {
            List<Post> allPosts = db.Posts.OrderBy(post => post.PublishDate).ToList<Post>();
                foreach (Post p in allPosts)
                {
                    p.CommentsList = db.Comments.Where(comment => comment.PostID == p.ID).ToList<Comment>();
                }
                return View(allPosts);             
        }


        public ActionResult GetMostUpdatedPost()
        {
            return View();
        }

    }
}
