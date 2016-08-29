using shuli_blog.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shuli_blog.Models
{
    public class FanCrud : ICrud<Fan>
    {
        private static string NEW_LINE = "\n";
        private FanContext db = new FanContext();

        public Fan index(int id)
        {
            //todo check if return works
            return db.Fans.Find(id);
        }

        public List<Fan> list()
        {
            return db.Fans.ToList();
        }

        public void details(Fan fan)
        {
            Console.WriteLine(fan.ID + NEW_LINE + fan.FirstName + NEW_LINE + fan.LastName + fan.gender + NEW_LINE + fan.Bday
                + NEW_LINE + fan.Seniority + NEW_LINE);
            
        }

        public bool delete(Fan fan)
        {
            if (db.Fans.Remove(fan).Equals(fan))
            {
                db.SaveChanges();
                return true;
            }
                
            return false;
        }

        public Fan create(Fan fan)
        {
            db.Fans.Add(fan);
            db.SaveChanges();
            return fan;
        }

    }
}