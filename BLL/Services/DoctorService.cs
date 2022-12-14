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
    public class DoctorService
    {
        public static DoctorDto AddDoctor(DoctorDto doctor)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DoctorDto, Doctor>();
                c.CreateMap<Doctor, DoctorDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Doctor>(doctor);
            var rt = DataAccessFactory.DoctorAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<DoctorDto>(rt);
            }
            return null;
        }
        public static List<DoctorDto> Get()
        {
            var data = DataAccessFactory.DoctorAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Doctor, DoctorDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<DoctorDto>>(data);
        }
        public static DoctorDto Get(int id)
        {
            var data = DataAccessFactory.DoctorAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Doctor, DoctorDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<DoctorDto>(data);
        }
        
    }
}
