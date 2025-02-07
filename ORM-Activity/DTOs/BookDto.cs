namespace ORM_Activity.DTOs
{
    public class CreateBook
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public long ISBN { get; set; }
        public long UserProfileId { get; set; }
        public long AuthorId { get; set; }   
    }

    public class GetBook
    {
        public long BookId { get; set; }

    }
    public class GetBookDto
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public long ISBN { get; set; }
        public long UserProfileId { get; set; }
        public long AuthorId { get; set; }

    }
}
