using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RiseHealthCare.Infrastructure.Data.Repositories.Management;

namespace RiseHealthCare.Infrastructure.IoC
{
    public static class DependenciesInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Contexts
            services.AddScoped<ApplicationDbContext>();
            //Mediator
            
            //Repositories
            services.AddScoped<IProfessionalRepository, ProfessionalRepository>();
           
            return services;
        }
    }
}