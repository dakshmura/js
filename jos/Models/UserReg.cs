namespace jos.Models;

    public class UserReg(string email)
{
        public required string Username { get; set; }

        public required string Password { get; set; }


        public required string ConfirmPassword { get; set; }

    public string Email { get; set; } = email;
}
