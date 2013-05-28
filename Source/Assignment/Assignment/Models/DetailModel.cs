using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class DetailModel
    {
        public tblFilm Film { get; set; }
        public List<tblComment> ListComment { get; set; }

    }
}