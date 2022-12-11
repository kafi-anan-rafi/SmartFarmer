using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<OrderDTO>>(data);
            return rt;
        }
        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<OrderDTO>(data);
            return rt;
        }
        public static OrderDTO Add(OrderDTO order)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var dborder = mapper.Map<Order>(order);
            var rt = DataAccessFactory.OrderDataAccess().Add(dborder);
            if (rt != null)
            {
                return mapper.Map<OrderDTO>(rt);
            }
            return null;
        }
        public static OrderDTO Delete(int id)
        {
            var rt = DataAccessFactory.OrderDataAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Order, OrderDTO>();
                });
                var mapper = new Mapper(config);
                var dbuser = mapper.Map<OrderDTO>(rt);
                return dbuser;
            }
            return null;
        }
        public static OrderDTO Update(OrderDTO order)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var dborder = mapper.Map<Order>(order);
            var rt = DataAccessFactory.OrderDataAccess().Update(dborder);
            if (rt != null)
            {
                return mapper.Map<OrderDTO>(rt);
            }
            return null;
        }
    }
}
