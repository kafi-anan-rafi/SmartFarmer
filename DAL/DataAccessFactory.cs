using DAL.EF;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Repo;
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
        // Rafi
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

        // Ridan

        public static IRepoRidan<Customer, int, Customer> CustomerAccess()
        {
            return new CustomerRepo();
        }
        public static IRepoRidan<Product, int, Product> ProductAccess()
        {
            return new ProductRepo();
        }
        public static IRepoRidan<Comment, int, Comment> CommentAccess()
        {
            return new CommentRepo();
        }

        // Sadman
        public static IrepoSadman<Farmer, int, Farmer> FarmerDataAccess()
        {
            return new FarmerRepo();
        }

        public static IrepoSadman<Equipment, int, Equipment> EquipmentDataAccess()
        {
            return new EquipmentRepo();

        }
        public static IrepoSadman<Loan, int, Loan> LoanDataAccess()
        {
            return new LoanRepo();
        }

        // Anisur
        public static IRepoRidan<Doctor, int, Doctor> DoctorAccess()
        {
            return new DoctorRepo();
        }
        public static IRepoRidan<Rating, int, Rating> RatingAccess()
        {
            return new RatingRepo();
        }
        public static IRepoRidan<Service, int, Service> ServiceAccess()
        {
            return new ServicesRepo();
        }
    }
}
