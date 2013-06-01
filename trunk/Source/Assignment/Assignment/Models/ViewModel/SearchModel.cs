using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.ViewModel
{
    public class SearchModel
    {
        public List<Film> ListResultFilm { get; set; }
        public List<Film> TopFilm { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}