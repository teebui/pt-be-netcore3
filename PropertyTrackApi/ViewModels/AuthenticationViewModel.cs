using System.ComponentModel.DataAnnotations;

namespace PropertyTrackApi.ViewModels
{
    public class AuthenticationViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}