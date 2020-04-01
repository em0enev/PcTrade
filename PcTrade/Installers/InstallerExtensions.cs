using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PcTrade.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServices(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes
                 .Where(type => typeof(IInstaller).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                 .Select(Activator.CreateInstance)
                 .Cast<IInstaller>()
                 .ToList();

            installers.ForEach(installer => installer.InstallServices(configuration, services));
        }

        public static void InstallApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes
                 .Where(type => typeof(IInstaller).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                 .Select(Activator.CreateInstance)
                 .Cast<IInstaller>()
                 .ToList();

            installers.ForEach(installer => installer.InstallServices(configuration, services));
        }
    }
}
