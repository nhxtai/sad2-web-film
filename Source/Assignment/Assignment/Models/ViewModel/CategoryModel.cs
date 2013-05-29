using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.ViewModel
{
    public class CategoryModel
    {
        public Category CurrentCat { get; set; }
        public List<Category> ListCategory { get; set; }
        public Account Account { get; set; }
        public List<Film> TopFilm { get; set; }
        public List<Film> FilmOfThisCategory { get; set; }
    }
}