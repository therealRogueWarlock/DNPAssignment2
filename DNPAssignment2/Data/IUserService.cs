
using Models;

namespace Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}