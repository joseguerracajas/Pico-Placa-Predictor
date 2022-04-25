using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pico_Placa_Predictor.Models;
using Pico_Placa_Predictor.Services;
using Pico_Placa_Predictor.Data;

namespace Pico_Placa_Predictor.Controllers
{
    public class PredictorController : Controller
    {
        PredictorService predictorServide = new PredictorService();
        // GET: PredictorController
        public ActionResult Index()
        {
            ViewBag.Restrictions = DataPicoPlaca.Restrictions;
            ViewBag.Holidays = DataPicoPlaca.Holidays;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Predict([Bind("PlateNumber,Date,Time")] Predictor predictor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var canBeOnRoad = predictorServide.CanBeonRoad(predictor);
                    TempData["result"] = canBeOnRoad;
                    TempData["plateNumber"] = predictor.PlateNumber;
                }
                catch(Exception ex)
                {
                    TempData["error"] = ex.Message;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
