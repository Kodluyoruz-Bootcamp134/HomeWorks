using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will calculate your average exam score");

            try
            {
                Console.Write("Please enter your midterm score:");
                int midTerm = Convert.ToInt32(Console.ReadLine()); //Midterm will affect %40 of your average score
                Console.Write("Please enter your final score:");
                int final = Convert.ToInt32(Console.ReadLine()); //Final exam will affect %60 of your average score

                double avgScore = midTerm * 0.4 + final * 0.6;


                if (midTerm <= 100 && final<=100) 
                {
                    Console.WriteLine($"Your average score is {Math.Round(avgScore)}");

                    if (final < 50 || avgScore < 50)
                    {
                        Console.WriteLine("Failed!");
                    }
                    else
                    {
                        Console.WriteLine("Pass!");
                    }
                }
                else
                {
                    Console.WriteLine("Midterm and Final exams are must be between 0-100");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid value");
            }

        }
    }
}
