using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microservices.Client.MVC.Models;
using Microservices.Client.MVC.Infrastructure.Agents.Sales;

namespace Microservices.Client.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISalesAgent _salesAgent;

        public HomeController(ILogger<HomeController> logger, ISalesAgent salesAgent)
        {
            _logger = logger;
            _salesAgent = salesAgent;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                var list = await _salesAgent.GetAsync();
                return View(list);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
