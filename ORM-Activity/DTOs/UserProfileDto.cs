using ORM_Activity.Models;

namespace ORM_Activity.DTOs
{
    public class CreateUserProfile
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public long UserId { get; set; }
        //public int BookId { get; set; }
    }

    public class GetUserProfile
    {
        public long UserProfileId { get; set; }

    }
    public class GetUserProfileDto
    {
        public long UserProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public long UserId { get; set; }
        //public int BookId { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
