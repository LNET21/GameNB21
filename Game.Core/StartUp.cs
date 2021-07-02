using Game.Core.Entities;
using Game.Core.GameWorld.Interfaces;
using Game.Core.UI;
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
            services.AddSingleton(configuration);
            services.AddSingleton<IMap, ConsoleMap>();
            services.AddSingleton<IUI, ConsoleUI>();
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