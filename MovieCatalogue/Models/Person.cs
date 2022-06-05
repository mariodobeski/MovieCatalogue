using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogue.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();

        public HashSet<Role> Roles { get; set; } = new HashSet<Role>();
    }
}
