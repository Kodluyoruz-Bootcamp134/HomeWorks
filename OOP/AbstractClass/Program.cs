using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hulk hulk = new Hulk();
            hulk.Add(hulk.name);
            hulk.SuperHeroPower();

            SpiderMan spider = new SpiderMan();
            spider.Add(spider.name);
            spider.SuperHeroPower();
        }
    }


    abstract class Power
    {
        public abstract void SuperHeroPower();
        public void Add(string name)
        {
            Console.WriteLine($"{name}! New Super Hero Added!");
        }
    }


    class SpiderMan : Power
    {

        public string name = "Spider Man";
        public override void SuperHeroPower()
        {
            Console.WriteLine("Spider senses and abilities");
        }
    }

    class Hulk : Power
    {
        public string name = "Hulk";
        public override void SuperHeroPower()
        {
            Console.WriteLine("Unlimited Power");
        }
    }
}
