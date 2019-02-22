using Microsoft.AspNetCore.Mvc;
using Prototypes.Services.Proxies.Interfaces;
using System.Collections.Generic;

namespace Prototypes.Services.Proxies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IServiceProxy<ITestService> _testServiceProxy;
        private readonly IServiceProxy<IUserService> _userServiceProxy;

        public TestController(
            IServiceProxy<ITestService> testServiceProxy,
            IServiceProxy<IUserService> userServiceProxy)
        {
            _testServiceProxy = testServiceProxy;
            _userServiceProxy = userServiceProxy;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery]int inputValue)
        {
            var value = _testServiceProxy.Invoke(a => a.MethodTwo(inputValue));
            var value2 = _userServiceProxy.Invoke(a => a.Register("me@smpx.io", "MyPassword"));

            return new OkObjectResult($"{value}\r\n{value2}");

        }
    }
}
