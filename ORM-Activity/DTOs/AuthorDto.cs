using ORM_Activity.Models;

namespace ORM_Activity.DTOs
{
    public class CreateAuthor
    {
        public long AuthorId { get; set; }
        public required string Name { get; set; }
        public string? Bio { get; set; }

    }
    public class GetAuthor
    {
        public long AuthorId { get; set; }

    }
    public class GetAuthorDto
    {
        public long AuthorId { get; set; }
        public required string Name { get; set; }
        public string? Bio { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<AuthorPublisher> AuthorsPublishers { get; set; }

    }
}
