using Microsoft.AspNetCore.Mvc;

namespace Dotnet5Issue.Controllers
{

    [ApiController]
    [Route("/")]
    public class TestController : ControllerBase
    {
        private readonly Test _test;

        public TestController(Test test)
        {
            _test = test;
        }

        [HttpGet]
        public string Get()
        {
            return _test.Print();
        }
    }
}
