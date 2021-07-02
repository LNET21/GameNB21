using Game.LimitedList;
using Microsoft.Extensions.Configuration;
using System;

namespace Game.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Environment.CurrentDirectory)
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .Build();

            //var ui = config.GetSection("game:ui").Value;
            //var x = config.GetSection("game:mapsettings:x").Value;
            //var mapsettings = config.GetSection("game:mapsettings").GetChildren();

            var startup = new StartUp();
            startup.SetUp();
                           

            //Game game = new Game();
            //game.Run();


            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
