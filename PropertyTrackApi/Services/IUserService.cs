using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace Services
{
    public interface IUserService
    {
        Task<UserViewModel> Authenticate(string username, string password);
        Task<List<UserViewModel>> GetUsers();
    }
}