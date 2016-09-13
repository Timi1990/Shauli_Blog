using shuli_blog.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shuli_blog.Models
{
    public class PostCrud : ICrud<Post>
    {
        private BloggingContext db = new BloggingContext();

        public Post index(int id)
        {
            //todo check if return works
            return db.Posts.Find(id);
        }

        public List<Post> list()
        {
            List<Post> list = db.Posts.ToList();
            return list;
        }

        public void details(Post post)
        {
            /*nsole.WriteLine(fan.ID + NEW_LINE + fan.FirstName + NEW_LINE + fan.LastName + fan.gender + NEW_LINE + fan.Bday
                + NEW_LINE + fan.Seniority + NEW_LINE);*/

        }

        public bool delete(Post post)
        {
            if (db.Posts.Remove(post).Equals(post))
            {
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public Post create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return post;
        }
    }
}