using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Predictor
    {
        [RegularExpression(@"[a-z]{3}[0-9]{4}",
            ErrorMessage = "Invalid plate number.")]
        [Required(ErrorMessage = "Please insert a valid plate numer")]
        public string? PlateNumber { get; set; }

        [Required(ErrorMessage = "Please insert the date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public Predictor(string plateNumber, DateTime date)
        {
            PlateNumber = plateNumber;
            Date = date;
        }
    }
}
