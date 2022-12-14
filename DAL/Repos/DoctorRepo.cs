using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DoctorRepo :Repo, IRepoRidan<Doctor, int, Doctor>
    {
        public Doctor Add(Doctor obj)
        {
            db.Doctors.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Doctors.Remove(dbobj);
            return db.SaveChanges() > 0;

        }

        public List<Doctor> Get()
        {
            return db.Doctors.ToList();
        }

        public Doctor Get(int id)
        {
            return db.Doctors.Find(id);
        }

        public Doctor Update(Doctor obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
