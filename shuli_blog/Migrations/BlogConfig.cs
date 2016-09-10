using shuli_blog.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace shuli_blog.Migrations
{
    public class BlogConfig : DbMigrationsConfiguration<BloggingContext>
    {
        public BlogConfig()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BloggingContext context)
        {

        }
    }
}