using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.ConfigServer.Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        // GET: api/Sales
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Order1", "Order2" };
        }

        // GET: api/Sales/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Order 0";
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
