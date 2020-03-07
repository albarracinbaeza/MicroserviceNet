using Microservices.Client.MVC.Infrastructure.Dto;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Client.MVC.Infrastructure.Agents.Sales
{
    public interface ISalesAgent
    {
        [Get("/")]
        Task<List<OrderDto>> GetAsync();
    }
}
