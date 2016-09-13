namespace shuli_blog.Migrations
{
    using shuli_blog.DAL;
    using shuli_blog.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BloggingContext>
    {
        private readonly bool _pendingMigrations;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            /*var migrator = new DbMigrator(this);
            _pendingMigrations = migrator.GetPendingMigrations().Any();
            if (_pendingMigrations)
            {
                migrator.Update();
                Seed(new BloggingContext());
            }*/
        }

        protected override void Seed(BloggingContext context)
        {
             new List<Post>
                          {
                              new Post{Title = "first", Author = "timi" , Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-01") , URL = "www.walla.co.il", Image = "bla.jpeg", Video = "cccccc.mp4"},
                              new Post{Title = "second", Author = "alex" , Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-03") , URL = "www.walla.co.il" , Image = "bla.jpeg", Video = "cccccc.mp4"},
                              new Post{Title = "third", Author = "yossi" ,  Body = "Bla bla", PublishDate = DateTime.Parse("1990-01-02") , URL = "www.walla.co.il" , Image = "bla.jpeg", Video = "cccccc.mp4"},
                          }.ForEach(i => context.Posts.Add(i));
            context.SaveChanges();
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
