using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.ViewModel;
using Assignment.Models.DAO;
namespace Assignment.Controllers
{
    public class FilmController : Controller
    {
        //
        // GET: /Film/View/id

        public ActionResult View(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "HomePage");
            }
            int filmId = id ?? 1;
            FilmDAO fiDao = new FilmDAO();
            AccountDAO accDao = new AccountDAO();
            CategoryDAO cDao = new CategoryDAO();
            CommentDAO commentDao = new CommentDAO();
            FilmDetailModel model = new FilmDetailModel
            {
                ListCategory = cDao.GetAllCategory(),
                Account = null,
                Film = fiDao.GetDetailAFilm(filmId),
                ListComment = commentDao.GetAllCommentOfAFilm(filmId),
                TopFilm = fiDao.GetTopFilm(5),
                NewFilm = fiDao.GetTopNewestFilm(5)
            };
            fiDao.IncreaseViewCount(filmId);//increase viewcount
            return View(model);
        }

        public ActionResult Comment(string username, string content, int? filmId)
        {
            long commnetId = -1;
            if (this.Session["username"] != null && Session["username"].Equals(username)
                && filmId != null && content.Length > 0)//recheck input
            {
                CommentDAO commentDao = new CommentDAO();
                commnetId = commentDao.AddNewComment(username, content, filmId ?? 0);
            }
            TempData["commentId"] = commnetId;
            return PartialView();
        }
    }
}
