using System;

namespace Odev1._2AsalSayi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            int counter = 0;
            for (int i = 2; i <= 10000; i++)
            {
                check = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        check++;
                        break;
                    }
                }
                if (check == 0)
                {
                    counter++;
                    Console.Write(i + "-");
                }

            }
        }
    }
}
