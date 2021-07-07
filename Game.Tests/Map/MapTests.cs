﻿using Game.Core.Entities;
using Game.Core.GameWorld;
using Game.Core.Services;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.LimitedList.Map
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapConstructor_GetCorrectWidth_IOptions()
        {
            //const int expected = 10;
            //var mapSettings = new Mapsettings { X = expected, Y = expected };

            //IOptions<Mapsettings> options = Options.Create(mapSettings);

            //var map = new ConsoleMap(options);

            //var actual = map.Width;

            //Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MapConstructor_GetCorrectWidth_MapService()
        {
            const int expected = 10;
            var mapServiceMock = new Mock<IMapService>();

            mapServiceMock.Setup(m => m.GetMap()).Returns((expected, expected));

            var map = new ConsoleMap(mapServiceMock.Object);

            var actual = map.Width;

            Assert.AreEqual(expected, actual);

        }
    }
}
