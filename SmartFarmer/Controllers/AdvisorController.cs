using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFarmer.Controllers
{
    public class AdvisorController : ApiController
    {
        [Route("api/advisors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors")]
        [HttpPost]
        public HttpResponseMessage Add(AdvisorDTO advisor)
        {
            var data = AdminService.Add(advisor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors")]
        [HttpPatch]
        public HttpResponseMessage Update(AdvisorDTO obj)
        {
            var data = AdminService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdminService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
} 