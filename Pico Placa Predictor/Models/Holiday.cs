using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Holiday
    {
        [Required(ErrorMessage = "Please insert the holiday description")]
        public String? Description { get; set; }

        [Required(ErrorMessage = "Please insert the holiday date")]
        public DateOnly Date { get; set; }

        public Holiday(string description, DateOnly date)
        {
            Description = description;
            Date = date;
        }

        public override string ToString() => Description + ": " + Date.ToString();
    }
}
