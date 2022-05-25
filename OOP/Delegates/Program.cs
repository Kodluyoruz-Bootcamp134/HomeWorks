using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        public delegate void FirstDelegate();
        public delegate void MessageCarrier(string name);
        public delegate void NumCarrier(int num);
        public delegate int Operator(int num1, int num2);



        static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static void Main(string[] args)
        {
            ////Main way of using Delegates-----------
            //Messages message = new Messages();
            //FirstDelegate firstDelegate = message.HelloMessage;
            //firstDelegate();
            //firstDelegate += message.ByeByeMessage;
            //firstDelegate();


            //MessagesToPerson toPerson = new MessagesToPerson();
            //MessageCarrier carrier = toPerson.MessageToWorker;

            //carrier("Gokcan");

            //NumCarrier numCarrier = toPerson.TradePackage;
            //numCarrier(1000);

            //Operations operations = new Operations();
            //Operator operator1 = operations.SumOperations;

            //var result = operator1(3, 5);
            //Console.WriteLine(result);

            //Good way of using Delegates-----------

            //var filtered = Filters.Filter(numbers, isEven);

            //var filtered = Filters.Filter(numbers, delegate (int c) { return c < 5; });

            var filtered = Filters.Filter(numbers, c => c % 2 == 0);

            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);
            //}

            filtered.ForEach(p => Console.WriteLine(p));
            filtered.Where(x => x % 5 == 0);


            //Func<int> getRandomNumber = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};

            //Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
        }

        

        static bool isEven(int item)
        {
            return item % 2 == 0;
        }
    }
}
