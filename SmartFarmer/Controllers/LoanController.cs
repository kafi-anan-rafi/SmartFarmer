﻿using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmerPart.Controllers
{
    public class LoanController : ApiController
    {
        [Route("api/Loan")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = LoanService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Loan/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = LoanService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Loan")]
        public HttpResponseMessage Add(LoanDTO loan)
        {
            var data = LoanService.AddLoan(loan);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/Loan/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = LoanService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Loan")]
        [HttpPatch]
        public HttpResponseMessage Update(LoanDTO obj)
        {
            var data = LoanService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
