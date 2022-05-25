using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
        public int id;
        public string name;
        public string lastName;

        public void welcome(string name, string lastName)
        {
            Console.WriteLine($"Welcome {name} {lastName}");
        }

    }

    class Workers
    {
        public int id;
        public string name;
        public string job;

        public Workers(int id, string name, string job)
        {
            this.id = id;
            this.name = name;
            this.job = job;
        }

        public void info(int id, string name, string job)
        {
            Console.WriteLine($"Id:{id} Name:{name} Job:{job}");
        }
    }
}
