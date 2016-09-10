using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shuli_blog.Services
{
    public class CommentService : IService<Comment>
    {

        private ICrud<Comment> commentCrud = new CommentCrud();


        public Comment index(int id)
        {
            return commentCrud.index(id);
        }

        public List<Comment> list()
        {
            return commentCrud.list();

        }

        public Comment create(Post post , string commentTitle , string commentAuthor , string authorUrl , string body)
        {
            Comment comment = createComment(post, commentTitle, commentAuthor, authorUrl, body);
            return commentCrud.create(comment);
        }
        public void details(Comment Comment)
        {
            commentCrud.details(Comment);
        }

        public bool delete(Comment Comment)
        {
            return commentCrud.delete(Comment);
        }

        private Comment createComment(Post post, string commentTitle, string commentAuthor, string authorUrl, string body)
        {
            Comment comment = new Comment();
            comment.Post = post;
            comment.PostID = post.ID;
            comment.CommentTitle = commentTitle;
            comment.CommentAuthor = commentAuthor;
            comment.AuthorURL = authorUrl;
            comment.Body = body;
            return comment;
        }

    }
}