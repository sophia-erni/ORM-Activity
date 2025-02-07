namespace ORM_Activity.Models
{
    public class AuthorPublisher
    {
        public long AuthorId { get; set; }
        public Author Author { get; set; }

        public long PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
