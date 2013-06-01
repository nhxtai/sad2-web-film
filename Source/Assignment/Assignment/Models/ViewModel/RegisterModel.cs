using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.ViewModel
{
    public class RegisterModel
    {
        public List<Film> TopFilm { get; set; }
        public Account Account { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}