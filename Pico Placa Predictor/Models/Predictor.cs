using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Predictor
    {
        [Required(ErrorMessage = "Please insert a valid plate number")]
        [RegularExpression(@"[a-zA-Z]{3}[0-9]{4}",
            ErrorMessage = "Please insert a correct format (PDB1234)")]
        public string? PlateNumber { get; set; }

        [Required(ErrorMessage = "Please insert the date")]
        [RegularExpression(@"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$",
            ErrorMessage = "The format must be DD/MM/YYYY")]
        public DateOnly Date { get; set; }

        [Required(ErrorMessage = "Please insert the time")]
        [RegularExpression(@"^(2[0-3]|[01]?[0-9]):([0-5]?[0-9])$",
            ErrorMessage = "The format must be HH:MM")]
        public TimeOnly Time { get; set; }

        public Predictor()
        {
        }

        public Predictor(string? plateNumber, DateOnly date, TimeOnly time)
        {
            PlateNumber = plateNumber;
            Date = date;
            Time = time;
        }
    }
}
