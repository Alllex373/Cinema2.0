using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaAPI.Controllers
{
    public class FilmsController : ApiController
    {
        private readonly IFilmServices _filmServices;

        public FilmsController()
        {
            _filmServices = new FilmServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var films = _filmServices.GetList();  //where GetList Create in Film services
            return Ok(films);
        }

        [HttpGet]

        public IHttpActionResult GetFilmById(int id)
        {
            var onefilm = _filmServices.FilmById(); //  Look like GetList().FirstOrDefault(x => x.Id == id)
            return Ok(onefilm);
        }

        [HttpPost]


        public IHttpActionResult AddFilm([FromBody] Film film)  //Film from models or froom EF
        {

        }


        [HttpDelete]

        public IHttpActionResult DeleteFilm(int id)
        {
            if (!ModelState.IsValid)
                return (BadRequest(ModelState));

            _filmServices.Delete(id);

            return Ok();
        }
    }
