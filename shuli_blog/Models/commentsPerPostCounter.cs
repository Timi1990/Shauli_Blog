using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shuli_blog.Models
{
    public class commentsPerPostCounter
    {
        public int Count { get; set; }

        public Post Post { get; set; }
    }
}