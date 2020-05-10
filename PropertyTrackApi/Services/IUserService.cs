using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyTrackApi.ViewModels;

namespace PropertyTrackApi.Services
{
    public interface IUserService
    {
        Task<UserViewModel> Authenticate(string username, string password);
        Task<List<UserViewModel>> GetUsers();
    }
}