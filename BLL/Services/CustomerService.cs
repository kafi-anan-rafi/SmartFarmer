﻿using AutoMapper;
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
    public class CustomerService
    {
        public static CustomerDto AddCustomer(CustomerDto customer)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<CustomerDto, Customer>();
                c.CreateMap<Customer, CustomerDto>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Customer>(customer);
            var rt = DataAccessFactory.CustomerAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<CustomerDto>(rt);
            }
            return null;
        }
        public static List<CustomerDto> Get()
        {
            var data = DataAccessFactory.CustomerAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<CustomerDto>>(data);
        }
        public static CustomerDto Get(int id)
        {
            var data = DataAccessFactory.CustomerAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerDto>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<CustomerDto>(data);
        }
        
    }
}
