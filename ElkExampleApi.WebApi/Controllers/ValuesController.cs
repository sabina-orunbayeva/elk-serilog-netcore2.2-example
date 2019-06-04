using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElkExampleApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            if (id == 0)
            {
                _logger.LogWarning("Id = {Id}", id);
            }
            else if (id==1)
            {
                _logger.LogInformation("Id = {Id}", id);
            }
            else
            {
                _logger.LogError("ALARM!!! Id={Id}",id);
            }

            return "value";
        }
    }
}
