using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MossadAgentsMvc.Models;
using System.Net.Http;

namespace MossadAgentsMvc.Controllers
{
    public class MissionController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        // GET: MissionController
        public async Task<ActionResult> Index()
        {
            var missions = await _httpClient.GetFromJsonAsync<Mission[]>("http://localhost:5192/api/Missions");
            return View(missions);
        }
       
        public async Task<ActionResult> Select(int id)
        {
            var content = new StringContent(string.Empty);
             await _httpClient.PutAsync($"http://localhost:5192/api/Missions/{id}", content);
            return RedirectToAction(nameof(Index));
        }

        // GET: MissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MissionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MissionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
