using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.ExtensionMethods
{
    public static class MapExtensions
    {
        private static readonly IGetMapSize defaultImplementation = new GetMapSize();

        public static IGetMapSize Implementation { private get; set; } = defaultImplementation;
        public static int GetMapSizeFor(this IConfiguration configuration, string name)
        {
            return Implementation.GetMapSizeFor(configuration, name);
        }
    }

    public class GetMapSize : IGetMapSize
    {
        public int GetMapSizeFor(IConfiguration configuration, string name)
        {
            var section = configuration.GetSection("game:mapsettings");
            return int.TryParse(section[name], out int result) ? result : 0;
        }
    }

    public interface IGetMapSize
    {
        int GetMapSizeFor(IConfiguration configuration, string name);
    }
}
