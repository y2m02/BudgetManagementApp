using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementApp.Repositories.Repositories;
using ProjectManagementApp.Services.Services;

namespace ProjectManagementApp.App.CompositionRoot
{
    public static class ServiceResolver
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            RegisterForms(services);

            RegisterServices(services);
            
            return services.BuildServiceProvider();
        }

        private static void RegisterForms(IServiceCollection services)
        {
            services
                .AddSingleton<FrmMain>()
                .AddSingleton<FrmTest>();
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
                    typeof(TestService).Assembly,
                    typeof(TestRepository).Assembly
                )
                .AddClasses(x => x.Where(
                    c => names.Any(
                        name => c.Name.EndsWith(name))
                    )
                )
                .AsMatchingInterface()
            );
        }
    }
}
