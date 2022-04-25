using Pico_Placa_Predictor.Models;
using Pico_Placa_Predictor.Data;
namespace Pico_Placa_Predictor.Services
{
    public class PredictorService
    {
        public bool CanBeonRoad(Predictor predictor)
        {
            DateOnly inputDate = predictor.Date;
            DayOfWeek inputDayOfWeek = inputDate.DayOfWeek;
            TimeOnly inputTime = predictor.Time;
            int inputLastDigit = getPlateNumberLastDigit(predictor.PlateNumber ?? "");

            var holidays = DataPicoPlaca.Holidays.FindAll(h => h.Date == inputDate).Count > 0;

            if (holidays) return true;

            var restrictons = DataPicoPlaca.Restrictions.FindAll(r =>
             {
                 return r.DayOfWeek == inputDayOfWeek && r.PlateNumbers.Contains(inputLastDigit) && r.Schedules?.FindAll(s => inputTime.IsBetween(s.StartTime, s.EndTime)).Count > 0;
             });

            return restrictons.Count == 0;

        }

        public int getPlateNumberLastDigit(String plateNumber) => Int32.Parse(plateNumber.Substring(plateNumber.Length - 1));
    }
}
