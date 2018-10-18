using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(5, "Green");
            Console.WriteLine(v.Color);
            Console.WriteLine(v.MaxNumPassengers);
        }
    }
}


