using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class AuthenticationViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}