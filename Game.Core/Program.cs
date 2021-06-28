using System;

namespace Game.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Kalle";
            var newString = name.AddString("Anka");

            name.Do();
            //var res2  = Extensions.AddString("Kalle", "Anka");
            var res4 = name.AddString("Hej");

            var title = "Inspector";
            var res =  title.AddString("Gadget");

            Console.WriteLine(res);

            Console.WriteLine(newString);

            //Game game = new Game();
            //game.Run();


            //Console.WriteLine("Thanks for playing");
            //Console.ReadKey();
        }
    }
}
