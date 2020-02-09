using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Persistence.API.Data.Dto;
using Microservice.Persistence.API.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Persistence.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        private OrdenRepository _ordenRepository;
        public OrdenController(OrdenRepository ordenRepository)
        {
            _ordenRepository = ordenRepository;
        }
        [HttpGet]
        public IList<OrdenDto> ObtenerOrdenes()
        {
            return _ordenRepository.ObtenerOrdenes();
        }
    }
}