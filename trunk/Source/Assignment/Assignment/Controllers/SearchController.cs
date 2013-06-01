using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.DAO;
using Assignment.Models.ViewModel;

namespace Assignment.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index(string keyword)
        {
            FilmDAO fiDao = new FilmDAO();
            CategoryDAO cDao = new CategoryDAO();
            SearchModel result = new SearchModel
            {
                ListResultFilm = fiDao.SearchFilm(keyword),
                TopFilm = fiDao.GetTopFilm(5),
                ListCategory = cDao.GetAllCategory(),
            };
            return View(result);
        }

    }
}
