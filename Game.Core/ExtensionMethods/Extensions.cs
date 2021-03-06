using Game.Core.Entities.Creatures;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using Game.Core.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Game.Core.ExtensionMethods
{
    public static class Extensions
    {
        //public static string AddString(this string name, string newString)
        //{
        //    return $"{name} {newString}";
        //}

        //internal static void Do(this string name)
        //{
        //    Console.WriteLine(name);
        //}

        internal static IDrawable CreatureAtExtension(this List<Creature> creatures, Cell cell)
        {
            IDrawable result = null;
            foreach (var creature in creatures)
            {
                if (creature.Cell == cell)
                {
                    result = creature;
                    break;
                }
            }
            return result;
        }

     

        internal static void GetUI(this ServiceCollection services, IConfiguration configuration)
        {
            var ui = configuration.GetSection("game:ui").Value;

            switch (ui)
            {
                case "console":
                    services.AddSingleton<IUI, ConsoleUI>();
                    break;
                //More Options
                default:
                    break;
            }
        }
    }
}
