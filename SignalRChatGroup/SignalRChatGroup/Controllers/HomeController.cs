using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRChatGroup.Models;

namespace SignalRChatGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IHubContext<LocationHub> _hubContext;

        public HomeController(ILogger<HomeController> logger, IHubContext<LocationHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task<IActionResult> Index(string group)
        {
            var a = new LocationTracking
            {
                Lat = 1,
                Long = 2
            };
            await _hubContext.Clients.Group(group).SendAsync("ReceiveMessage", a);
            return View();
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
