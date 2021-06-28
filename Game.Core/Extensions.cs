using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core
{
   public static class Extensions
    {
        public static string AddString(this string name, string newString)
        {
            return $"{name} {newString}";
        }

        internal static void Do(this string name)
        {
            Console.WriteLine(name);
        }
    }
}
