namespace ORM_Activity.Models
{
    public class Book
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }  
        public long ISBN { get; set; }
        
        //Foreign Key
        public long UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

        //Foreign Key
        public long AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
