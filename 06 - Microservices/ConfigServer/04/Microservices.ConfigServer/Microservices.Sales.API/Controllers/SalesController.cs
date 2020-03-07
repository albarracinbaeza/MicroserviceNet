using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.Sales.API.Application;
using Microservices.Sales.API.Infrastructure.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly SalesApplication _salesApplication;
        public SalesController(SalesApplication salesApplication)
        {
            _salesApplication = salesApplication;
        }
        // GET: api/Sales
        [HttpGet]
        public List<OrderDto> Get()
        {
            return _salesApplication.ListOrders();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Sales/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sales
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sales/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
