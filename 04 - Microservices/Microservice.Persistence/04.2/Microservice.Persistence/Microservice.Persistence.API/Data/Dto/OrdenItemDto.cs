
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Persistence.API.Data.Dto
{
    public class OrdenItemDto
    {
        public int OrdenItemId { get; set; }
        public int OrdenId { get; set; }
        public int  ProductoId { get; set; }
        public string Descripcion { get; set; }
        public Decimal? Precio { get; set; }
    }
}
