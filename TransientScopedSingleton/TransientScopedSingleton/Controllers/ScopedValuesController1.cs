using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace TransientScopedSingleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopedValuesController1 : ControllerBase
    {
        private readonly IRandomNumberService _service1;
        private readonly IRandomNumberService2 _service2;

        public ScopedValuesController1(IRandomNumberService2 service2, IRandomNumberService service1)
        {
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet]
        public String Get()
        {
            int num1 = _service1.RandomNum;
            int num2 = _service2.GetRandomNum1();
            return $"RandomNumber:{num1}  ---    RandomNumber2.GetRandomNum1.RandomNum:{num2}";
        }
    }
}
