using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlLab
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int Year;

        public Movie(string title, string director, int year)
        {
            Title = title;
            Director = director;
            Year = year;
        }
    }
}
