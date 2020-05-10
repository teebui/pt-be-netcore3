using PropertyTrackApi.Models;

namespace PropertyTrackApi.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            // NOP
        }
        public UserViewModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Token = user.Token;            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }        
    }
    
}