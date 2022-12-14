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
    public class ServicesService
    {
        public static ServicesDto AddServices(ServicesDto services)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ServicesDto, DAL.EF.Service>();
                c.CreateMap<DAL.EF.Service, ServicesDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<DAL.EF.Service>(services);
            var rt = DataAccessFactory.ServiceAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ServicesDto>(rt);
            }
            return null;
        }
        public static List<ServicesDto> Get()
        {
            var data = DataAccessFactory.ServiceAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DAL.EF.Service, ServicesDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<ServicesDto>>(data);
        }
        public static ServicesDto Get(int id)
        {
            var data = DataAccessFactory.ServiceAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DAL.EF.Service, ServicesDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<ServicesDto>(data);
        }
        
    }
}
