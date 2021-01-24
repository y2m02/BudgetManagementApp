using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Mappings;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetManagementApp.CompositionRoot
{
    public static class ServiceResolver
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<BudgetManagementAppContext>();

            RegisterServices(services);

            return services.BuildServiceProvider();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            var names = new List<string>
            {
                "Service",
                "Repository",
            };

            // Install-Package Scrutor
            services.Scan(scan =>
                scan.FromAssemblies(
                        typeof(BaseService).Assembly,
                        typeof(BaseRepository).Assembly
                    )
                    .AddClasses(x => x.Where(
                            c => names.Any(
                                name => c.Name.EndsWith(name))
                        )
                    )
                    .AsMatchingInterface()
                    .FromAssemblies(typeof(FrmMain).Assembly)
                    .AddClasses(x => x.Where(c => c.Name.StartsWith("Frm")))
                    .AsSelf()
            );

            var mappingConfig = new MapperConfiguration(
                mc => { mc.AddProfile(new ProfileMapper()); }
            );

            services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}