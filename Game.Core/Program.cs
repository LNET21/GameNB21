using Game.LimitedList;
using Microsoft.Extensions.Configuration;
using System;

namespace Game.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var startup = new StartUp();
            startup.SetUp();

            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
