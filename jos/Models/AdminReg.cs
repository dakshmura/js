namespace jos.Models;

    public class AdminReg
    {
       
        public required string Username { get; set; }

       
        public required string Password { get; set; }

        public required string ConfirmPassword { get; set; }

        public required string Email { get; set; }
    }
