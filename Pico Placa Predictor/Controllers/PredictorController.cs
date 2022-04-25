﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pico_Placa_Predictor.Models;
using Pico_Placa_Predictor.Services;

namespace Pico_Placa_Predictor.Controllers
{
    public class PredictorController : Controller
    {
        PredictorService predictorServide = new PredictorService();
        // GET: PredictorController
        public ActionResult Index()
        {
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
                    var canBeOnRoad = predictorServide.canBeonRoad(predictor);
                    TempData["result"] = canBeOnRoad;
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
