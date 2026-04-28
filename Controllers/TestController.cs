using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPIForCI_CD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
        [HttpGet("name")]
        public IActionResult GetName()
        {
            return Ok("Md Rakibul Islam");
        }
        [HttpGet("age")]
        public IActionResult GetAGe()
        {
            return Ok("Md Rakibul Islam");
        }
    }
}
