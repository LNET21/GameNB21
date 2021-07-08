using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("Game.Tests")]
namespace Game.Core
{
   public static class StaticTestExample
    {
        public static bool WordLengthIsTen(string word)
        {
            return word.Length == 10;
        }
    }
    
    internal class SomeCode
    {

        private Func<string, bool> predicate;

        public SomeCode()
        {
            predicate = StaticTestExample.WordLengthIsTen;
        }

        public SomeCode(Func<string, bool> predicate)
        {
            this.predicate = predicate;
        }

        public bool HereWeUseStaticTestExample()
        {
            var word = "Banan";
            var res = predicate(word);

            //Code
            //Code
            //Code
            //Code

            return res;

        }
    }
}
