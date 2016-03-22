using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie_V1._3.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
     

        public string Reviews { get; set; }
        public int StarRate { get; set; }
        public int MovieId   { get; set; }
    }
}