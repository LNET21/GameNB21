using Game.Core.Entities;
using Game.Core.Entities.Items;
using Game.Core.ExtensionMethods;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using Game.Core.Services;
using Game.Core.UI;
using Game.LimitedList;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Game.Core
{
    internal class StartUp
    {
        private IConfiguration configuration;

        internal void SetUp()
        {
             configuration = GetConfig();
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetRequiredService<Game>().Run();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<Game>();
            services.AddSingleton<IMapService, MapService>();
            services.AddSingleton(configuration);
            services.AddSingleton<IMap, ConsoleMap>();
            services.GetUI(configuration);
            services.AddSingleton(configuration.GetSection("game:mapsettings").Get<Mapsettings>());
            services.Configure<Mapsettings>(configuration.GetSection("game:mapsettings").Bind);
            services.AddSingleton<ILimitedList<string>>(new MessageLog<string>(6));
            services.AddSingleton<ILimitedList<Item>>(new MessageLog<Item>(3));

        }

        private IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .Build();
        }
    }
}