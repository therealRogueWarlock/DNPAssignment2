using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Data.Impl
{
    public class RandomAuthStateProvider: AuthenticationStateProvider
    {
        
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new System.NotImplementedException();
        }
        
    }
}