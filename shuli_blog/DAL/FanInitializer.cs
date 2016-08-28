using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.DAL
{
    public class FanInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FanContext>
    {
        protected override void Seed(FanContext context)
        {
            var fans = new List<Fan>
            {
                new Fan(1,"Timi","P",new DateTime(18/10/1990),1),
                new Fan(2,"Yoav","S",new DateTime(13/09/1990),1),
                new Fan(3,"Bla","B",new DateTime(02/04/1992),2)
            };
            fans.ForEach(s => context.Fans.Add(s));
            context.SaveChanges();
        }
    }
}
