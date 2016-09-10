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
        [Required]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [ForeignKey("PostID")] 
        public Post Post { get; set; }

        [Required]
        public int PostID { get; set; }

        [Required]
        [Display(Name = "CommentTitle")]
        public string CommentTitle { get; set; }

        [Required]
        [Display(Name = "CommentAuthor")]
        public string CommentAuthor { get; set; }

        [Required]
        [Display(Name = "AuthorURL")]
        public string AuthorURL { get; set; }

        [Required]
        public string Body { get; set; }

        

    }
}
