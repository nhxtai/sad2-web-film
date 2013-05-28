using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class FilmController : Controller
    {
        //
        // GET: /Film/View/id

        public ActionResult View(int id)
        {
            DataContextDataContext ass = new DataContextDataContext();
            tblFilm film = ass.tblFilms.SingleOrDefault(f => f.FilmID == id);
            DetailModel dm = new DetailModel();
            dm.Film = film;
            dm.ListComment = null;
            return View(dm);
        }

    }
}
