using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogue.Models.Data
{
    public class MovieCreate
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string IMDBURL { get; set; }
        public string ImageURL { get; set; }

        public IList<int> GenresIds { get; set; }
        public IList<int> PeopleIds { get; set; }
    }
}
