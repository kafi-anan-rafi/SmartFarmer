using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RatingRepo : Repo, IRepoRidan<Rating, int, Rating>
    {
        public Rating Add(Rating obj)
        {
            db.Ratings.Add(obj);
            if(db.SaveChanges()>0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Ratings.Remove(dbobj);
            return db.SaveChanges()>0;            
        }

        public List<Rating> Get()
        {
            return db.Ratings.ToList();
        }

        public Rating Get(int id)
        {
            return db.Ratings.Find(id);
        }

        public Rating Update(Rating obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
