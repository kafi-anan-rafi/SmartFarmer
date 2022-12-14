using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LoanRepo : Repo, IrepoSadman<Loan, int, Loan>
    {
        public Loan Add(Loan obj)
        {
            db.Loans.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Loans.Remove(dbobj);
            return db.SaveChanges() > 0;

        }

        public List<Loan> Get()
        {
            return db.Loans.ToList();
        }

        public Loan Get(int id)
        {
            return db.Loans.Find(id);
        }

        public Loan Update(Loan obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
