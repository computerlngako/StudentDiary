namespace StudentDiary.Services.DTOs
{
    public class UserRegisterDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
