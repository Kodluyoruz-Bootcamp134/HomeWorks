using System;

namespace Study1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double discriminant, root1, root2;
            
            Console.WriteLine("Calculate root of Quadratic Equation : ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");

            try
            {
                Console.Write("Input the value of a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of c : ");
                c = Convert.ToInt32(Console.ReadLine());

                discriminant = b * b - 4 * a * c;                               //discriminant calculation
                if (discriminant == 0)                                          //if discriminant == 0 then roots must be same
                {
                    Console.WriteLine("Both roots are equal.");
                    root1 = -b / (2.0 * a);
                    root2 = root1;
                    Console.WriteLine($"First  Root Root1: {root1}");
                    Console.WriteLine($"Second Root Root2: {root2}");
                }
                else if (discriminant > 0)
                {
                    Console.WriteLine("Both roots are real and different");

                    root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine($"First  Root Root1: {root1}");
                    Console.WriteLine($"Second Root Root2: {root2}");
                }
                else                                                            //if discriminant < 0 then solution set must be empty.
                    Console.Write("Root are imaginary. There is no Solution. \n\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please input only integer values.", e);
            }

            
        }
    }
}
