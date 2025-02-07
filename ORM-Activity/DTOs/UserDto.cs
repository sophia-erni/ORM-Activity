namespace ORM_Activity.DTOs
{
    public class CreateUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class GetUser
    {
        public long UserId { get; set; }


    }
    public class GetUserDto
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
