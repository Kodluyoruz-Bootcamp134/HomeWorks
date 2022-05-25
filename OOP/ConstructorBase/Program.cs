using System;

namespace ConstructorBase
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person(124, "Gokcan" , "Coach");
            person1.Add();
            Person person2 = new Person(133, "Michael", "Teacher");
            person2.Add();

        }
    }



    class Main
    {
        private int _id;

        public Main(int id)
        {
            _id = id;
        }

        public void Message()
        {
            Console.WriteLine("ID:{0}", _id);
        }
    }

    class Person : Main
    {
        private string _name;
        private string _job;

        public Person(int id, string name , string mission) : base(id)
        {
            _name = name;
            _job = mission;
        }

        public void Add()
        {
            Console.WriteLine("Name:{0} Job:{1}---Added!",_name, _job);
            Message();
        }
    }



}
