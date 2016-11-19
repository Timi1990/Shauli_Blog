using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Models

{
    public class Post
    {
        const int MAX_POST_SIZE = 1024;

        [Required]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "PostTitle")]
        public string Title { get; set; }

        


        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "AuthorsWebsite")]
        public string URL { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "PublishDate")]
        public DateTime PublishDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Postsbody")]
     
        public string Body { get; set; }

        [Display(Name = "Video")]
        [DataType(DataType.Text)]
        public String Video { get; set; }

        [Display(Name = "Image")]
        [DataType(DataType.Text)]
        public String Image { get; set; }
        
        [Display(Name = "RelatedComments")]
        [DisplayFormat(NullDisplayText = "NoComments")]
        public List<Comment> CommentsList { get; set; }

    }
}
