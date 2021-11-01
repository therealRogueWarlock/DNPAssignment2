
using System.Threading.Tasks;
using Models;

namespace Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
    }
    
}