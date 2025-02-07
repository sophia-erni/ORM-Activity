using ORM_Activity.Models;

namespace ORM_Activity.DTOs
{
    public class CreatePublisher
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class GetPublisher
    {
        public long PublisherId { get; set; }

    }
    public record GetPublisherDto
    {
        public long PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<AuthorPublisher> AuthorsPublishers { get; set; }

    }
}
