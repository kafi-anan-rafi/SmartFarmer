using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
    }
}
