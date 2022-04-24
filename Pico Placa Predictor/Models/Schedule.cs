using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Schedule
    {
        [Required(ErrorMessage = "Please insert the start time")]
        public TimeOnly StartTime { get; set; }

        [Required(ErrorMessage = "The time is required.")]
        public TimeOnly EndTime { get; set; }

    }
}
