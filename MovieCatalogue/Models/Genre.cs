using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogue.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int MovieId { get; set; }

        public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();

    }
}
