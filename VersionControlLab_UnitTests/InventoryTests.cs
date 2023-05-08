namespace VersionControlLab
{
    public class InventoryTests
    {
        [Fact]
        public void Inventory_Constructor_InitializesBooksAndMovies()
        {
            Inventory inventory = new Inventory();

            Assert.Equal(new List<Book>(), inventory.Books);
            Assert.Equal(new List<Movie>(), inventory.Movies);
        }

        [Fact]
        public void Inventory_AddBook_AddsBookToBooks()
        {
            Inventory inventory = new Inventory();
            Book lotr = new Book("Lord of the Rings", "JRR Tolkien");
            
            inventory.AddBook(lotr);

            Assert.Equal(lotr, inventory.Books[0]);
        }

        [Fact]
        public void Inventory_AddMovie_AddsMovieToMovies()
        {
            Inventory inventory = new Inventory();
            Movie fuzz = new Movie("Hot Fuzz", "Edgar Wright", 2007);

            inventory.AddMovie(fuzz);

            Assert.Equal(fuzz, inventory.Movies[0]);
        }

        [Fact]
        public void Inventory_StealBook_RemovesBookFromBooks()
        {
            Book lotr = new Book("Lord of the Rings", "JRR Tolkien");
            Inventory inventory = new Inventory();

            inventory.AddBook(lotr);
            inventory.StealBook(lotr);

            Assert.Empty(inventory.Books);
        }

        [Fact]
        public void Inventory_StealMovie_RemovesMovieFromMovies()
        {
            Movie fuzz = new Movie("Hot Fuzz", "Edgar Wright", 2007);
            Inventory inventory = new Inventory();

            inventory.AddMovie(fuzz);
            inventory.StealMovie(fuzz);

            Assert.Empty(inventory.Movies);
        }
    }
}