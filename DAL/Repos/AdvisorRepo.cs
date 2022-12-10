using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdvisorRepo : IUser<Advisor, int, Advisor>
    {
        SmartFarmerDBEntities db;
        internal AdvisorRepo()
        {
            db = new SmartFarmerDBEntities();
        }
        public Advisor Add(Advisor obj)
        {
            db.Advisors.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Advisor Delete(Advisor obj)
        {
            var dbobj = Get(obj.Id);
            db.Advisors.Remove(dbobj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public List<Advisor> Get()
        {
            return db.Advisors.ToList();
        }

        public Advisor Get(int id)
        {
            return db.Advisors.Find(id);
        }

        public Advisor Update(Advisor obj)
        {
            var dbojb = Get(obj.Id);
            db.Entry(dbojb).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
