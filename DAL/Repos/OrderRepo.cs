using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : IRepo<Order, int, Order>
    {
        SmartFarmerDBEntities db;
        internal OrderRepo()
        {
            db = new SmartFarmerDBEntities();
        }
        public Order Add(Order obj)
        {
            db.Orders.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Order Delete(int id)
        {
            var dbobj = Get(id);
            if (dbobj != null)
            {
                db.Orders.Remove(dbobj);
                if (db.SaveChanges() > 0)
                {
                    return dbobj;
                }
                return null;
            }
            return null;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public Order Update(Order obj)
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
