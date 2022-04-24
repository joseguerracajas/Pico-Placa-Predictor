using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Holiday
    {
        [Required(ErrorMessage = "Please insert the holiday description")]
        public String? Description { get; set; }

        [Required(ErrorMessage = "Please insert the holiday date")]
        public DateOnly StartTime { get; set; }

    }
}
