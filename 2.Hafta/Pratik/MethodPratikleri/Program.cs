using System;
using System.Collections.Generic;

namespace MethodPratikleri
{
    class Program
    {
        static void Main(string[] args)
        {

            helloWorld();

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int resultDD = divide(num1, num2);
            Console.WriteLine(resultDD);

            int resultAA = sum(num1, num2);
            Console.WriteLine(resultAA);


            int resultBB = sum(num1, num2, num3);
            Console.WriteLine(resultBB);


            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            var res = isPrime(num);

            if (!res)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }




            List<int> numbers = new List<int>() { 5, 10, 15, 5, 3, 20, 30, 8, 6 };

            int resultCC = getAverageOfList(numbers);
            Console.WriteLine(resultCC);

        }

        static int getAverageOfList(List<int> numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                total = total + numbers[i];
            }
            return total / numbers.Count;
        }

        static void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }


        /// <summary>
        /// Sum Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int sum(int a, int b)
        {
            return a + b;
        }


        static int sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// This Method Will Check The Number is Prime or Not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool isPrime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i ==0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }


        static int divide(int num1, int num2)
        {
            int result = num1 + num2;
            return result / 2;
        }
    }
}
