using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PcTrade.Installers
{
    public interface IInstaller
    {
        void InstallServices(IConfiguration configuration, IServiceCollection services);
    }
}
