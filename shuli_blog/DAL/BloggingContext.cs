using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace shuli_blog.DAL
{
    public class BloggingContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<FanClub> Clubs { get; set; }

        public DbSet<Fan> Fans { get; set; }

        public BloggingContext()
            : base("BloggingContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<BloggingContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}