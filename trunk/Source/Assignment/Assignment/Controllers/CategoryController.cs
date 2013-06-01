using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models.DAO;
using Assignment.Models.ViewModel;
namespace Assignment.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult View(int id)
        {
            CategoryDAO cDao = new CategoryDAO();
            FilmDAO fiDao = new FilmDAO();
            var listCat = cDao.GetAllCategory();
            CategoryModel cm = new CategoryModel()
            {
                ListCategory = listCat,
                CurrentCat = cDao.GetACategory(id),
                Account = null,
                TopFilm = fiDao.GetTopFilm(5),
                NewFilm = fiDao.GetTopNewestFilm(5),
                FilmOfThisCategory = fiDao.GetListFilmOfACategory(id),

            };
            return View(cm);
        }

    }
}
