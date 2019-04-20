using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Areas.Admin.Controllers
{
    public class AdminFilmController : Controller
    {
        // GET: Admin/AdminFilm
        public ActionResult AdminFilm()
        {
            return View();
        }
    }
}