using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlLab
{
    public class MovieTests
    {
        [Fact]
        public void Movie_Constructor_InitializesTitleDirectorAndYear()
        {
            Movie fuzz = new Movie("Hot Fuzz", "Edgar Wright", 2007);

            Assert.Equal("Hot Fuzz", fuzz.Title);
            Assert.Equal("Edgar Wright", fuzz.Director);
            Assert.Equal(2007, fuzz.Year);
        }
    }
}
