using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.ViewModel;
using Assignment.Models.DAO;

namespace Assignment.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

        public ActionResult Home()
        {
            FilmDAO fiDao = new FilmDAO();
            AccountDAO accDao = new AccountDAO();
            CategoryDAO cDao = new CategoryDAO();
            HomeModel home = new HomeModel
            {
                MainListFilm = fiDao.GetListFilm(),
                TopFilm = fiDao.GetTopFilm(5),
                NewFilm = fiDao.GetTopNewestFilm(5),
                Account = null,
                ListCategory = cDao.GetAllCategory(),
            };
            return View(home);
        }

    }
}
