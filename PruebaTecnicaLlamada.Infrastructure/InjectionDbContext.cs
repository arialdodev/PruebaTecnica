using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.SeedWork;
using PruebaTecnicaLlamada.Infrastructure.Persistence;
using PruebaTecnicaLlamada.Infrastructure.Repositories;

namespace PruebaTecnicaLlamada.Infrastructure
{
    public static class InjectionDbContext
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PruebaTecnicaLlamadaDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IRepository<Deportista>, DeportistaRepository>();

            return services;
              
        }

    }
}
