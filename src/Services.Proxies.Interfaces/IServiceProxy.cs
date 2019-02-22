using System;

namespace Prototypes.Services.Proxies.Interfaces
{
    public interface IServiceProxy<TService> where TService : IService
    {
        void Invoke(Action<TService> serviceMethod);

        TResponse Invoke<TResponse>(Func<TService, TResponse> serviceMethod);
    }
}
