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
    public class EquipmentService
    {
        public static EquipmentDTO AddEquipment(EquipmentDTO equipment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<EquipmentDTO, Equipment>();
                c.CreateMap<Equipment, EquipmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Equipment>(equipment);
            var rt = DataAccessFactory.EquipmentDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<EquipmentDTO>(rt);
            }
            return null;
        }
        public static List<EquipmentDTO> Get()
        {
            var data = DataAccessFactory.EquipmentDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Equipment, EquipmentDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<EquipmentDTO>>(data);
        }
        public static EquipmentDTO Get(int id)
        {
            var data = DataAccessFactory.EquipmentDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Equipment, EquipmentDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<EquipmentDTO>(data);
        }
        public static EquipmentDTO Delete(int id)
        {
            var rt = DataAccessFactory.EquipmentDataAccess().Delete(id);
            if (!rt)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Equipment, EquipmentDTO>();
                });
                var mapper = new Mapper(config);
                var dbequipment = mapper.Map<EquipmentDTO>(rt);
                return dbequipment;
            }
            return null;
        }
        public static EquipmentDTO Update(EquipmentDTO Equipment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EquipmentDTO, Equipment>();
                cfg.CreateMap<Equipment, EquipmentDTO>();
            });
            var mapper = new Mapper(config);
            var dbEquipment = mapper.Map<Equipment>(Equipment);
            var rt = DataAccessFactory.EquipmentDataAccess().Update(dbEquipment);
            if (rt != null)
            {
                return mapper.Map<EquipmentDTO>(rt);
            }
            return null;
        }
    }
}
