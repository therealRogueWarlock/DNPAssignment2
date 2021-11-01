
using Blazor_Authentication.model;
using Models;

namespace Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}