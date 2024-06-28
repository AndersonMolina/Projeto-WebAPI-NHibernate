using Projeto_WebAPI_NHibernate.Models.Infra.Data.Repositories;
using Projeto_WebAPI_NHibernate.Models.Services;
using Projeto_WebAPI_NHibernate.Models.Infra.Data.Extensions;

namespace Projeto_WebAPI_NHibernate.Models.IoC
{
    public static class Projeto_WebAPI_NHibernateConfig
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            string connStr = configuration.GetConnectionString("clienteDB");

            services.AddNHibernate(connStr);

            services.AddScoped<iClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
        }
    }
}
