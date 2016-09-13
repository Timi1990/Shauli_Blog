using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.DAL
{
    public class FanContext : DbContext
    {
        public DbSet<Fan> Fans { get; set; }

        public FanContext()
            : base("FanContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<FanContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
