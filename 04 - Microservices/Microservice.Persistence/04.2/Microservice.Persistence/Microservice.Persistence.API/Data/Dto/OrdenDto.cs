using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Persistence.API.Data.Dto
{
    public class OrdenDto
    {
        public int OrdenId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<OrdenItemDto> Items { get; set; }
    }
}
