using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlLab
{
    public class Inventory
    {
        public List<Book> Books;
        public List<Movie> Movies;

        public Inventory()
        {
            Books = new List<Book>();
            Movies = new List<Movie>();
        }
    }
}
