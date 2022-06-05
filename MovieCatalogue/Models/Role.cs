
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalogue.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public HashSet<Person> People { get; set; } = new HashSet<Person>();
    }
}
