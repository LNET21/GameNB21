using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.LimitedList;
using System;

namespace Game.Tests.LimitedList
{
    [TestClass]
    public class LimitedListTests
    {
        [TestMethod]
        public void Constructor_NegativeCapacity_Returns_1()
        {
            //Arrange
            const int expected = 1;
            const int capacity = -10;

            //Act
            var list = new LimitedList<int>(capacity);

            //Assert
            Assert.AreEqual(list.Capacity, expected);
        }

        [TestMethod]
        public void Capacity_ReturnsExcpectedCapacity_ShouldPass()
        {
            const int expected = 10;

            var list = new LimitedList<int>(expected);

            Assert.AreEqual(list.Capacity, expected);
        }

        [TestMethod]
        public void Add_WhenFull_Should_Return_False()
        {
            const int capacity = 1;

            var list = new LimitedList<int>(capacity);
            var ok = list.Add(1);
            var shouldBeFalse = list.Add(2);
            var actual = list.IsFull;

            Assert.IsTrue(ok);
            Assert.IsFalse(shouldBeFalse);
           // Assert.AreEqual(list.Capacity, capacity);
            Assert.IsTrue(actual);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_ParameterNull_Should_Throw()
        {
            var list = new LimitedList<string>(1);

            try
            {
                var trying = list.Add(null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
