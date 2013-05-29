using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class FilmDetailModel
    {
        public Film Film { get; set; }
        public List<Comment> ListComment { get; set; }
    }
}