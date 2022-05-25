using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.logger = new Firebase();
            manager.Add();

            
        }
    }

    interface ILogger
    {
        void Log();
    }

    class Manager
    {
        public ILogger logger;
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer added!");
        }

    }

    class SqlDatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class MongoDb : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to MongoDb!");
        }
    }

    class Firebase : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Firebase");
        }
    }




}
