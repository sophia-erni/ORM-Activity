namespace ORM_Activity.Models
{
    public class Author
    {
        public long AuthorId { get; set; }
        public required string Name { get; set; }
        public string? Bio { get; set; }
        
        public ICollection<Book> Books { get; set; }

        public ICollection<AuthorPublisher> AuthorsPublishers { get; set; }
        

    }
}
