using Microservices.Client.MVC.Infrastructure.Agents.Sales;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Client.MVC.Infrastructure.Agents
{
    public static class RestClientsInstaller
    {
        public static IServiceCollection AddSalesRestClient(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ISalesAgent), typeof(SalesAgent));
            
            return services;
        }
    }
}
