using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class DetailModel
    {
        public Film Film { get; set; }
        public List<Comment> ListComment { get; set; }
    }
}