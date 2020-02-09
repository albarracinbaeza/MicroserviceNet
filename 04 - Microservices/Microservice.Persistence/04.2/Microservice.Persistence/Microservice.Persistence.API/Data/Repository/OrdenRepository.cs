using Microservice.Persistence.API.Data.Context;
using Microservice.Persistence.API.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Persistence.API.Data.Repository
{
    public class OrdenRepository
    {
        private MicroserviceEFCoreContext _microserviceEFCoreContext;
        public OrdenRepository(MicroserviceEFCoreContext microserviceEFCoreContext)
        {
            _microserviceEFCoreContext = microserviceEFCoreContext;
        }

        public IList<OrdenDto> ObtenerOrdenes()
        {
            var queryOrden = from o in _microserviceEFCoreContext.Ordens
                        select new OrdenDto{
                            OrdenId = o.OrdenId,
                            Descripcion = o.Descripcion
                        };

            var queryItems = from oi in _microserviceEFCoreContext.OrdenItems
                             join p in _microserviceEFCoreContext.Productos
                                on oi.ProductoId equals p.ProductoId
                             select new OrdenItemDto
                             {
                                 OrdenItemId = oi.OrdenItemId,
                                 OrdenId = oi.OrdenId,
                                 Descripcion = p.Descripcion,
                                 ProductoId = p.ProductoId,
                                 Precio = p.Precio
                             };

            List<OrdenDto> ordenes = queryOrden.ToList();
            List<OrdenItemDto> items = queryItems.ToList();

            ordenes.ForEach(orden =>
            {
                orden.Items = items.Where(w => w.OrdenId == orden.OrdenId).ToList();
            });

            return ordenes;
        }
    }
}
