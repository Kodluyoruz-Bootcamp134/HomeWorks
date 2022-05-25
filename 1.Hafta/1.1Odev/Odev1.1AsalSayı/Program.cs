using System;

namespace Odev1._1AsalSayı
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this program we will check the number entered by user is prime or not.

            int counter = 0;
            int num = 0;
            int i = 2;
            BEGIN:
            Console.Write("Please Enter a Number:"); 
            //To avoid errors, we should check the user entered  a number or not.
            try
            {
                num = Convert.ToInt32(Console.ReadLine()); 
            }
            catch (FormatException errorMsj)
            {
                Console.WriteLine(errorMsj.Message+ "Please enter a valid value!");
                goto BEGIN;
            }

            while (i < num) 
            {
                if (num % i==0)
                {
                    counter++;
                }
                i++;
            }

            if(counter != 0)
            {
                Console.WriteLine("Not Prime!");
            }
            else
            {
                Console.WriteLine("Prime!");
            }
        }

    }
}
