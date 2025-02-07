namespace ORM_Activity.Models
{
    public class Publisher
    {
        public long PublisherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<AuthorPublisher> AuthorsPublishers { get; set; }

    }
}
