using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ServicesRepo : Repo, IRepoRidan<Service, int, Service>
    {
        public Service Add(Service obj)
        {
            db.Services.Add(obj);
            if (db.SaveChanges() > 0) { return obj; }
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Services.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Service> Get()
        {
            return db.Services.ToList();
        }

        public Service Get(int id)
        {
            return db.Services.Find(id);
        }

        public Service Update(Service obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
