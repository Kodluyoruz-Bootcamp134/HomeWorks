using System;

namespace Study2_PrimeNumbers
{
    class Program
    {
        public static void IsPrimeNumber()
        {
            //Attemp to find if an input is prime or not

            try
            {
                Console.WriteLine("Input a number and check if it's a Prime Number...");
                Console.WriteLine("--------------------------------------------------\n");
                Console.Write("The number:  ");
                uint number = Convert.ToUInt32(Console.ReadLine());                         //input from user
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)                                                    //to check if number evenly divided by i
                    {
                        Console.WriteLine($"\n\nThe given number:   {number}    -->     is NOT a PRIME NUMBER.");
                        number = 0;
                        break;
                    }
                }
                if (number != 0)                                                            //if it's not evenly divided by whole i integers, then it's a Prime Number
                    Console.WriteLine($"\n\nThe given number:   {number}    -->     is a PRIME NUMBER.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a valid number.\n\n");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Please input a valid number.\n\n");
            }
            Console.WriteLine("\n\n");

        }

        public static void PrimeNumbers(uint number=10000)
        {
            Console.WriteLine("The Prime Numbers, between 1-10000:  ");
            Console.WriteLine("-----------------------------------\n");
            bool isPrime = true;
            for (int i = 3; i < number; i += 2)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }

        static void Main(string[] args)
        {
            
            IsPrimeNumber();
            //PrimeNumbers();

        }
    }
}
