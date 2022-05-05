using System;
using System.Collections.Generic;

namespace week2_Study_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Mardin", "Istanbul", "Diyarbakır", "Istanbul", "Mardin", "Istanbul" };
            List<string> removedDuplicatedCities = new List<string>();

            removeDuplicates(cities, removedDuplicatedCities); //This method is checking for duplications and adding unique ones on another list.

            foreach (var city in removedDuplicatedCities)
            {
                Console.WriteLine(city);                    //Write new collection.
            }
        }

        private static void removeDuplicates(List<string> cities, List<string> removedDuplicatedCities)
        {
            foreach (var city in cities)
            {
                if (!removedDuplicatedCities.Contains(city)) //This if checks for is there any duplication on second list.
                    removedDuplicatedCities.Add(city);       //Add if there is no any duplication.
                else
                    continue;
            }
        }
    }
}
