namespace BookManagementAPI.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string PublicationYear { get; set; }
        public required string Genre { get; set; }
        public int ViewCount { get; set; } = 0;
    }
}
