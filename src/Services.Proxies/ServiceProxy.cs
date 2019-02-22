using Prototypes.Services.Proxies.Interfaces;
using System;

namespace Prototypes.Services.Proxies
{
    public class ServiceProxy<TService> : IServiceProxy<TService> where TService : IService
    {
        private readonly TService _service;

        public ServiceProxy(TService service)
        {
            _service = service;
        }

        public void Invoke(Action<TService> serviceMethod)
        {
            //do some logging?

            serviceMethod.Invoke(_service);
        }

        public TResponse Invoke<TResponse>(Func<TService, TResponse> serviceMethod)
        {
            // do some logging?

            return serviceMethod.Invoke(_service);
        }
    }
}
