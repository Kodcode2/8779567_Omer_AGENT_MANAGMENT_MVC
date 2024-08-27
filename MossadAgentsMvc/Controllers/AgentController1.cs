using Microsoft.AspNetCore.Mvc;
using MossadAgentsMvc.Models;

namespace MossadAgentsMvc.Controllers
{
    public class AgentController1 : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task<ActionResult> Index()
        {
            var agents = await _httpClient.GetFromJsonAsync<Agent[]>("http://localhost:5192/api/Agents");
            return View(agents);
        }
    }
}
