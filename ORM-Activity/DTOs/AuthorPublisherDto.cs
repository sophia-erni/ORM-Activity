using ORM_Activity.Models;

namespace ORM_Activity.DTOs
{
    public class GetAuthorPublisher
    {
        public long AuthorId { get; set; }
        public long PublisherId { get; set; }


    }
    public class GetAuthorPublisherDto
    {
        public long AuthorId { get; set; }
        public Author Author {  get; set; }
        public long PublisherId { get; set; }
        public Publisher Publisher { get; set; }


    }
}
