using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Restriction
    {
        [Required(ErrorMessage = "Please insert the restriction day of week")]
        public DayOfWeek DayOfWeek { get; set; }

        [Required(ErrorMessage = "Please insert the restriction schedule list")]
        public List<Schedule>? Schedules { get; set; }

        [Required(ErrorMessage = "Please insert the restriction plate numbers")]
        [Range(1, 7,
        ErrorMessage = "The index range must be between 1 (Monday) and 7 (Sunday)")]
        public List<int> PlateNumbers { get; set; }

        public Restriction(DayOfWeek dayOfWeek, List<Schedule> schedules, List<int> plateNumbers)
        {
            DayOfWeek = dayOfWeek;
            Schedules = schedules;
            PlateNumbers = plateNumbers;
        }

        public override string ToString() => DayOfWeek + " cant be on road plate numbers ending in " + String.Join(",", PlateNumbers) + " in the schedules " + String.Join(",", Schedules!);

    }
}
