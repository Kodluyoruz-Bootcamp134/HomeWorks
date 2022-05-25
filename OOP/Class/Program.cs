using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.id = 124;
            person.name = "Gokcan";
            person.lastName = "Eren";

            person.welcome(person.name, person.lastName);


            Workers worker = new Workers(27, "Eren", "Tailor");

            worker.info(worker.id, worker.name, worker.job);

        }
    }
}
