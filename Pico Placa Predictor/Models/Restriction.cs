using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Restriction
    {
        [Required(ErrorMessage = "Please insert the restriction day")]
        public DateOnly Day { get; set; }

        [Required(ErrorMessage = "Please insert the restriction schedule list")]
        public List<Schedule>? Schedules { get; set; }

        public Restriction(DateOnly day, List<Schedule> schedules)
        {
            Day = day;
            Schedules = schedules;
        }
    }
}
