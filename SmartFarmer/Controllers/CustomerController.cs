﻿using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace SmartFarm.Controllers
{
      // GET: Customer
    public class CustomerController : ApiController
    {
        [Route("api/Customer")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CustomerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Customer/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = CustomerService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Customer/add")]
        public HttpResponseMessage Add(CustomerDto customer)
        {
            var data = CustomerService.AddCustomer(customer);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
    
}