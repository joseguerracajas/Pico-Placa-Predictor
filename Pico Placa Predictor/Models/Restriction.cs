using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Restriction
    {
        [Required(ErrorMessage = "Please insert the restriction index day")]
        public int IndexDay { get; set; }

        [Required(ErrorMessage = "Please insert the restriction schedule list")]
        public List<Schedule>? Schedules { get; set; }

        [Range(1, 7,
        ErrorMessage = "The index range must be between 1 (Monday) and 7 (Sunday)")]
        public List<int> PlateNumbers { get; set; }

        public Restriction(int indexDay, List<Schedule> schedules, List<int> plateNumbers )
        {
            IndexDay = indexDay;
            Schedules = schedules;
            PlateNumbers = plateNumbers;
        }
    }
}
