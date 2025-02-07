using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_Activity.Models
{
    public class UserProfile
    {
        public long UserProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Foreign Key
        [ForeignKey("UserId")]
        public long UserId { get; set; }
        public User User { get; set; }

        //Foreign Key
        //public long BookId { get; set; }
        //public Book Book { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}
