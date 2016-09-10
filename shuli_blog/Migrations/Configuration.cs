namespace shuli_blog.Migrations
{
    using shuli_blog.DAL;
    using shuli_blog.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FanContext context)
        {
            /*var fans = new List<Fan>
            {
                new Fan{FirstName = "artiom", LastName = "petrov",Bday = DateTime.Parse("1990-01-01"),  Seniority = 1},
                new Fan{FirstName = "yoav", LastName = "stezki",Bday = DateTime.Parse("1990-01-02"), Seniority = 2},
                new Fan{FirstName = "bla", LastName = "bla",Bday = DateTime.Parse("1990-01-03"), Seniority = 3},
                new Fan{FirstName = "bla22", LastName = "bla22",Bday = DateTime.Parse("1990-01-07"), Seniority = 4}
            };
            fans.ForEach(s => context.Fans.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();*/
            
        }
    }
}
