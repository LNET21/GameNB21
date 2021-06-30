using Game.Core.Entities.Creatures;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
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
    }
}
