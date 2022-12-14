using AutoMapper;
using BLL.DTOs;
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
    public class RatingService
    {
        public static List<RatingDto> Get()
        {
            var data = DataAccessFactory.RatingAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<List<RatingDto>>(data);
            return rt;
        }
        public static RatingDto Get(int id)
        {
            var data = DataAccessFactory.RatingAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(config);
            var rt = mapper.Map<RatingDto>(data);
            return rt;
        }
        public static RatingDto AddRating(RatingDto rating)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<RatingDto, Rating>();
                c.CreateMap<Rating, RatingDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Rating>(rating);
            var rt = DataAccessFactory.RatingAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<RatingDto>(rt);
            }
            return null;
        }
    }
}
