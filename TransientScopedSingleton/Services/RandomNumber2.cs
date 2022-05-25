using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RandomNumber2 : IRandomNumberService2
    {
        private readonly IRandomNumberService _service;

        public int RandomNum2 { get; }

        public RandomNumber2(IRandomNumberService service)
        {
            _service = service;

            RandomNum2 = new Random().Next(0, 100);
        }

        public int GetRandomNum1()
        {
            return _service.RandomNum;
        }
    }
}
