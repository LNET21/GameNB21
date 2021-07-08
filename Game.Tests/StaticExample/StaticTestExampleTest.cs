using Game.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.LimitedList.StaticExample
{
    [TestClass]
   public class StaticTestExampleTest
    {
        [TestMethod]
        public void StaticTest_Example()
        {
            var expected = false;
            var someCode = new SomeCode(s => expected);

            var actual = someCode.HereWeUseStaticTestExample();

            Assert.IsFalse(actual);
        }
    }
}
