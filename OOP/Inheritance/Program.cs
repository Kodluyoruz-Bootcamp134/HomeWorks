using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Goky";
            student1.age = 27;
            student1.major = "Chinese Language and Literature";

            Employee worker1 = new Employee();
            worker1.name = "Wang Li";
            worker1.age = 43;
            worker1.job = "Teacher";

            
            List<Person> personList = new List<Person>();

            personList.Add(student1);
            personList.Add(worker1);

            Console.WriteLine($"{personList[0]} {personList[1]}");
            Console.WriteLine($"{personList[0].name}");
            Console.WriteLine($"{personList[1].name}");

        }
    }
}
