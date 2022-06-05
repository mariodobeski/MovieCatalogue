using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogue.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string IMDBURL { get; set; }
        public string ImageURL { get; set; }

        public HashSet<Genre> Genres { get; set; } = new HashSet<Genre>();
        public HashSet<Person> People { get; set; } = new HashSet<Person>();

        
    }
}
