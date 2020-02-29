using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.ConfigServer.Client
{
    public class FetcherOptions
    {
        public string BaseDataUri { get; set; }
        public TimeSpan FetchInterval { get; set; }
    }
}
