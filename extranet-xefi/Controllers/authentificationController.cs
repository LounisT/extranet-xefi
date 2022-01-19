using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace extranet_xefi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class authentificationController : ControllerBase
    {

        private readonly ILogger<authentificationController> _logger;

        public authentificationController(ILogger<authentificationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "AuthentificationAvec4Parametres2")]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "test", "test" };
         
        }
    }
}
