using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Models
{
    public class Comment
    {
        public int ID { get; set; }

        
        public Post Post { get; set; }

        public int PostID { get; set; }

        public string CommentTitle { get; set; }

        public string CommentAuthor { get; set; }

        public string AuthorURL { get; set; }

        
        public string Body { get; set; }

        

    }
}
