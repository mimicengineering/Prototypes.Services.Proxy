using Prototypes.Services.Proxies.Interfaces;

namespace Prototypes.Services.Proxies
{
    public class UserService : IUserService
    {
        public string Register(string email, string password)
        {
            return $"12345_{email}_67890_{password}";
        }
    }
}
