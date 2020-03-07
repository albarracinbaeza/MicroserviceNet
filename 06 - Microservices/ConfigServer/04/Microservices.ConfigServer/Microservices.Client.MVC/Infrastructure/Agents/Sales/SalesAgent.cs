using Microsoft.Extensions.Configuration;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using RestEase;
using Polly.Retry;
using Steeltoe.Common.Discovery;
using Microservices.Client.MVC.Infrastructure.Dto;

namespace Microservices.Client.MVC.Infrastructure.Agents.Sales
{
    public class SalesAgent:ISalesAgent
    {
        private readonly ISalesAgent agent;
        private readonly IDiscoveryClient _discoveryClient;

        private static AsyncRetryPolicy retryPolicy = Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(retryCount: 3, sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(3)); 
        public SalesAgent(IConfiguration configuration, IDiscoveryClient discoveryClient)
        {
            _discoveryClient = discoveryClient;
            var handler = new DiscoveryHttpClientHandler(discoveryClient);
            //Certificado no valido
            handler.ServerCertificateCustomValidationCallback = delegate { return true; };
            var httpClient = new HttpClient(handler, false)
            {
                BaseAddress = new Uri(configuration.GetValue<string>("SaleServiceURL"))
            };
            agent = RestClient.For<ISalesAgent>(httpClient);
        }

        public Task<List<OrderDto>> GetAsync()
        {           
            return retryPolicy.ExecuteAsync(async () => await agent.GetAsync());
        }
    }
}
