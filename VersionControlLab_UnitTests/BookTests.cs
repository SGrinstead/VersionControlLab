using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControlLab
{
    public class BookTests
    {
        [Fact]
        public void Book_Constructor_InitializesTitleAndAuthor()
        {
            Book lotr = new Book("Lord of the Rings", "JRR Tolkien");

            Assert.Equal("Lord of the Rings", lotr.Title);
            Assert.Equal("JRR Tolkien", lotr.Author);
        }
    }
}
