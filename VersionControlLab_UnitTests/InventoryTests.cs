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
    }
}