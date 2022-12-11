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
    public class UserController : ApiController
    {
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO advisor)
        {
            var data = UserService.Add(advisor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users")]
        [HttpPatch]
        public HttpResponseMessage Update(UserDTO obj)
        {
            var data = UserService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
