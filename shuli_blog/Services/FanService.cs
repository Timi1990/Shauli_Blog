using shuli_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shuli_blog.Services
{
    public class FanService : IService<Fan>
    {
        ICrud<Fan> fanCrud = new FanCrud();

        public Fan index(int id)
        {
            return fanCrud.index(id);
        }

        public List<Fan> list()
        {
            return fanCrud.list();

        }

        public Fan create(string fname, string lname, DateTime bday, int seniority)
        {
            Fan fan = createFan(fname,lname,bday,seniority);
            return fanCrud.create(fan);
        }
        public void details(Fan fan)
        {
            fanCrud.details(fan);
        }

        public bool delete(Fan fan)
        {
            return fanCrud.delete(fan);
        }

        private Fan createFan(string fname, string lname, DateTime bday, int seniority)
        {
            Fan fan = new Fan();
            fan.FirstName = fname;
            fan.LastName = lname;
            fan.Bday = bday;
            fan.Seniority = seniority;
            return fan;
        }
    }
}
