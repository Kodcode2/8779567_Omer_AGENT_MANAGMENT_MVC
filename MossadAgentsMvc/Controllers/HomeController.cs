using Microsoft.AspNetCore.Mvc;
using MossadAgentsMvc.Models;
using System.Diagnostics;
using System.Net.Http;

namespace MossadAgentsMvc.Controllers
{

    public class HomeController : Controller
    {

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public async Task<ActionResult> ProposeMissions()
        {
            var missions = await _httpClient.GetFromJsonAsync<Mission[]>("http://localhost:5192/api/Missions");



            return View();
        }
    }
}
