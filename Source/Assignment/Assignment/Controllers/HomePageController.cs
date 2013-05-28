using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;
namespace Assignment.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/

        public ActionResult Home()
        {
            DataContextDataContext assignment = new DataContextDataContext();
            var list = assignment.tblFilms.ToList();
            HomeModel hm = new HomeModel();
            hm.Account = null;
            hm.MainListFilm = list;
            hm.TopDayFilm = null;
            hm.TopWeekFilm = null;
            return View(hm);
        }

    }
}
