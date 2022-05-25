using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RandomNumber : IRandomNumberService
    {
        public int RandomNum { get; }

        public RandomNumber()
        {
            RandomNum=new Random().Next(0,100);
        }
    }
}
