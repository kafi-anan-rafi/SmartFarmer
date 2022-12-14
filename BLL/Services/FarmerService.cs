using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FarmerService
    {
        public static FarmerDTO AddFarmer(FarmerDTO Farmer)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FarmerDTO, Farmer>();
                c.CreateMap<Farmer, FarmerDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Farmer>(Farmer);
            var rt = DataAccessFactory.FarmerDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<FarmerDTO>(rt);
            }
            return null;
        }
        public static List<FarmerDTO> Get()
        {
            var data = DataAccessFactory.FarmerDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Farmer, FarmerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<FarmerDTO>>(data);
        }
        public static FarmerDTO Get(int id)
        {
            var data = DataAccessFactory.FarmerDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Farmer, FarmerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<FarmerDTO>(data);
        }
        public static FarmerDTO Delete(int id)
        {
            var rt = DataAccessFactory.FarmerDataAccess().Delete(id);
            if (!rt)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Farmer, FarmerDTO>();
                });
                var mapper = new Mapper(config);
                var dbFarmer = mapper.Map<FarmerDTO>(rt);
                return dbFarmer;
            }
            return null;
        }
        public static FarmerDTO Update(FarmerDTO Farmer)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FarmerDTO, Farmer>();
                cfg.CreateMap<Farmer, FarmerDTO>();
            });
            var mapper = new Mapper(config);
            var dbFarmer = mapper.Map<Farmer>(Farmer);
            var rt = DataAccessFactory.FarmerDataAccess().Update(dbFarmer);
            if (rt != null)
            {
                return mapper.Map<FarmerDTO>(rt);
            }
            return null;
        }
    }
}

