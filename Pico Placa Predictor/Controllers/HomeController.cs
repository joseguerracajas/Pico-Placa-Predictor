using Microsoft.AspNetCore.Mvc;
using Pico_Placa_Predictor.Models;
using Pico_Placa_Predictor.Services;
using System.Diagnostics;

namespace Pico_Placa_Predictor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PredictorService predictorService = new PredictorService();
            Predictor predictor = new Predictor("PDL-7591", new DateOnly(2022,4,25), new TimeOnly(8,15));
            predictorService.canBeonRoad(predictor);
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