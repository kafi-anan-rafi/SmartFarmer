using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdvisorRepo : Repo, IRepo<Advisor, int, Advisor>
    {
        public Advisor Add(Advisor obj)
        {
            db.Advisors.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Advisor Delete(int id)
        {
            var dbobj = Get(id);
            if(dbobj != null)
            {
                db.Advisors.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
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
