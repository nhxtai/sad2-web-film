using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class HomeModel
    {
        public List<tblFilm> MainListFilm { get; set; }
        public List<tblFilm> TopDayFilm { get; set; }
        public List<tblFilm> TopWeekFilm { get; set; }

        public tblAccount Account { get; set; }
    }
}