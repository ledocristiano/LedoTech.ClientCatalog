using LedoTech.ClientCatalog.Application.Interfaces;
using LedoTech.ClientCatalog.Application.Services;
using LedoTech.ClientCatalog.Domain.CourseContext.Interfaces.Repositories;
using LedoTech.ClientCatalog.Domain.CourseContext.Models;
using LedoTech.ClientCatalog.Infra.Data.Repository.Dapper;
using LedoTech.ClientCatalog.Infra.Data.Repository.EntityFramework;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LedoTech.ClientCatalog.Infra.CrossCutting.IoC
{
    public class IoC
    {
        public static void Configure(IServiceCollection services)
        {
            // Application Services
            services.AddScoped(typeof(IClientAppService), typeof(ClientAppService));

            // Repositories
            services.AddTransient(typeof(IClientWriteOnlyRepository), typeof(ClientWriteOnlyRepository));
            services.AddTransient(typeof(IClientReadOnlyRepository), typeof(ClientReadOnlyRepository));

            // MediatR service
            services.AddMediatR(typeof(Client).GetTypeInfo().Assembly);
        }
    }
}
