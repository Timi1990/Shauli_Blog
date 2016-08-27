using shuli_blog.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
 
namespace shuli_blog.Models
{
    public class FanCrud : ICrud<Fan>
    {
        private FanContext db = new FanContext();
        
        public Fan index(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fan> list()
        {
            var query = from fan in db.fans select fan;

           return query.ToList();
        }

        public void details(Fan entity)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Fan create()
        {
            throw new NotImplementedException();
        }
   
}