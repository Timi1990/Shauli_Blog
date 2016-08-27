using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.DAL
{
    public class FanContext : DbContext
    {

        public DbSet<Fan> fans { get; set; }

    }
}
