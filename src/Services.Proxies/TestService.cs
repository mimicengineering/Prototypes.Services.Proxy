using Prototypes.Services.Proxies.Interfaces;

namespace Prototypes.Services.Proxies
{
    public class TestService : ITestService
    {
        public void MethodOne()
        {

        }

        public bool MethodTwo(int number)
        {
            return number == 3;
        }
    }
}
