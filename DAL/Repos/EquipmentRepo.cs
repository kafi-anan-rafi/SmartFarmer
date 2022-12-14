using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EquipmentRepo: Repo, IrepoSadman<Equipment, int,Equipment>
    {
        public Equipment Add(Equipment obj)
        {
            db.Equipments.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Equipments.Remove(dbobj);
            return db.SaveChanges() > 0;

        }

        public List<Equipment> Get()
        {
            return db.Equipments.ToList();
        }

        public Equipment Get(int id)
        {
            return db.Equipments.Find(id);
        }

        public Equipment Update(Equipment obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
