using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace TransientScopedSingleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRandomNumberService _service;

        public ValuesController(IRandomNumberService service)
        {
            _service = service;       
        }

        [HttpGet]
        public String Get()
        {
            var num = _service.RandomNum;
            return num.ToString();
        }
    }
}
