using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElkExampleApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly ILogger<ObjectController> _logger;

        public ObjectController(ILogger<ObjectController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int number, string text)
        {
            var obj = new {number, text};

            _logger.LogInformation("{@Object}", obj);

            return Ok(new {obj});
        }
    }
}