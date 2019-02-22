namespace Prototypes.Services.Proxies.Interfaces
{
    public interface IUserService : IService
    {
        string Register(string email, string password);
    }
}
