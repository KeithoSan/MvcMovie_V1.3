using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie_V1._3.Models
{

    public class MovieDBContext : DbContext
    {

        //public MovieDBContext () : base ("name=DefaultConnection");
        //{
        //}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieReview> Reviews { get; set; }
    }
}