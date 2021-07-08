using Game.Core.Entities;
using Game.Core.GameWorld.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.LimitedList.StartUp
{
    [TestClass]
    public class StartUpTests
    {
        [TestMethod]
        public void ConfigureServices_CreateCorrectInstanceOfMap()
        {
            var serviceCollection = new ServiceCollection();
            var startup = new Game.Core.StartUp();

            startup.ConfigureServices(serviceCollection);
            var provider = serviceCollection.BuildServiceProvider();

            var map = provider.GetRequiredService<IMap>();

            Assert.IsInstanceOfType(map, typeof(ConsoleMap));
        }
    }
}
