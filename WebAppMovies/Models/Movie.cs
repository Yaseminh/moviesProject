using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppMovies.db;

namespace WebAppMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
        public string MovieSrc { get; set; }
        public string MovieDesc { get; set; }

        public Comment myMovie { get; set; }

        public Movie()
        {

        }
        public Movie(Movy mov)
        {
            Id = mov.Id;
            MovieName = mov.MovieName;
            MovieImage = mov.MovieImage;
            MovieSrc = mov.MovieSrc;
            MovieDesc = mov.MovieDesc;

        }
    }
}
