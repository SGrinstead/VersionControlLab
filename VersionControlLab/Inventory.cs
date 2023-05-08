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

        //Add Methods
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        //We haven't implemented a currency system so for now you just have to steal things
        public void StealBook(Book book)
        {
            Books.Remove(book);

            Console.WriteLine($"You are now the proud owner of {book.Title} by {book.Author}");
        }

        public void StealMovie(Movie movie)
        {
            Movies.Remove(movie);

            Console.WriteLine($"You are now the proud owner of {movie.Title}");
        }
    }
}
