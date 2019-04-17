using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaAPI.Controllers
{
    public class SessionsController : ApiController
    {
        private readonly ISessionServices _sessionServices;

        public SessionsController()
        {
            _sessionServices = new SessionServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var sessions = _sessionServices.GetList();
            return Ok(sessions);
        }

        [HttpGet]

        public IHttpActionResult GetSessionById(int id)
        {
            var onesession = _sessionServices.SessionById();
            return Ok(onesession);
        }
    }
}
