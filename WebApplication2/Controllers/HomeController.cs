using LugxGaming.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM USERSS");
            return View(dt);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}