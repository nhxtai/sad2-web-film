using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.DAO;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class FilmController : Controller
    {
        //
        // GET: /Film/View/id

        public ActionResult View(int? ID)
        {
            if (ID == null)
            {
                return RedirectToAction("Home", "HomePage");
            }
            int filmId = ID ?? 1;     
            FilmDAO fiDao = new FilmDAO();
            AccountDAO accDao = new AccountDAO();
            CategoryDAO cDao = new CategoryDAO();
            CommentDAO commentDao = new CommentDAO();
            FilmDetailModel model = new FilmDetailModel
            {
                ListCategory = cDao.GetAllCategory(),
                Account = null,
                Film = fiDao.GetDetailAFilm(filmId),
                ListComment = commentDao.GetAllCommentOfAFilm(filmId)
            };
            return View(model);
        }

    }
}
