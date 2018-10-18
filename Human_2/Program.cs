using System;

namespace Human_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Kyle = new Human("Kyle", 10, 10, 10, 1000);
            Human Monster = new Human("Monster", 10, 10, 10, 1000);
            Kyle.Attack(Monster);
            Kyle.Attack(Monster);
            Monster.Attack(Kyle);
            Kyle.Attack(Monster);
            Kyle.Attack(Monster);
            Monster.Attack(Kyle);
            Console.WriteLine(Kyle.Health);
            Console.WriteLine(Monster.Health);
        }
    }
}
