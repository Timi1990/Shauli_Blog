using shuli_blog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shuli_blog.Models
{
    public class CommentCrud : ICrud <Comment>
    {

        private BloggingContext db = new BloggingContext();

        public Comment index(int id)
        {
            //todo check if return works
            return db.Comments.Find(id);
        }

        public List<Comment> list()
        {
            return db.Comments.ToList();
        }

        public void details(Comment comment)
        {
            /*nsole.WriteLine(fan.ID + NEW_LINE + fan.FirstName + NEW_LINE + fan.LastName + fan.gender + NEW_LINE + fan.Bday
                + NEW_LINE + fan.Seniority + NEW_LINE);*/

        }

        public bool delete(Comment comment)
        {
            if (db.Comments.Remove(comment).Equals(comment))
            {
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public Comment create(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return comment;
        }
    }
}