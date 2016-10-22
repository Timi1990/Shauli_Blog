using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using shuli_blog.DAL;
using shuli_blog.Models;
using shuli_blog.Controllers;
using System.Web.Routing;

namespace shuli_blog.Controllers
{
    public class PostController : Controller
    {
        private BloggingContext db = new BloggingContext();

        // GET: Post
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // GET: Post/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Author,URL,PublishDate,Body,Video,Image")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.PublishDate = DateTime.Now;
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "BlogPage", action = "Index"}));
            }

            return View(post);
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Author,URL,PublishDate,Body,Video,Image")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult SearchPost()
        {
            return View();
        }

        public ActionResult PostBySearchResult(string title, DateTime? date, string author_name, string author_website, string comments_words)
        {
            List<Post> PostList = new List<Post>();

            if (comments_words == string.Empty)
            {
                PostList = db.Posts.Where(post => ((title == "") || post.Title.Contains(title)) &&
                                                      ((author_name == "") || post.Author.Contains(author_name)) &&
                                                     ((date == null) || post.PublishDate == date) &&
                                                     ((author_website == "") || post.URL.Contains(author_website))).ToList<Post>();


            }
            else
            {
                var result = db.Comments.AsQueryable().Where(comm => comm.Body.Contains(comments_words)).Join(db.Posts,
                    comm => comm.PostID,
                    pos => pos.ID,
                    (comm, pos) => new
                    {
                        id = pos.ID,
                        title = pos.Title,
                        authorName = pos.Author,
                        authorSite = pos.URL,
                        publishDate = pos.PublishDate,
                        content = pos.Body
                    });


                foreach (var item in result)
                {
                    Post p = new Post();
                    p.ID = item.id;
                    p.Title = item.title;
                    p.Author = item.authorName;
                    p.URL = item.authorSite;
                    p.PublishDate = item.publishDate;
                    p.Body = item.content;
                    PostList.Add(p);
                }
            }
            ViewBag.SearchReuslt = PostList.Count;
            return PartialView("SearchPost", PostList);
            
        }

        public ActionResult EditComments(int id)
        {
            List<Comment> list = db.Comments.Where(comment => comment.PostID == id).ToList<Comment>();
            return View(list);
        }

    }
}
