using Game.LimitedList;
using System;

namespace Game.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LimitedList<int>(2);

            foreach (var item in list)
            {

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            var name = "Kalle";

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Game game = new Game();
            game.Run();


            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
