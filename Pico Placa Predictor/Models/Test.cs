using System.ComponentModel.DataAnnotations;

namespace Pico_Placa_Predictor.Models
{
    public class Test
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int id { get; set; }

        [RegularExpression(@"[a-z]{3}[0-9]{4}",
            ErrorMessage = "Invalid plate number.")]
        [Required(ErrorMessage = "The plate number is required.")]
        public string plate { get; set; }

        [Required(ErrorMessage = "The date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dateToCheck { get; set; }

        [Required(ErrorMessage = "The time is required.")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime timeToCheck { get; set; }

    }
}
