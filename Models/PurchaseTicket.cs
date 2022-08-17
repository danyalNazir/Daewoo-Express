using System.ComponentModel.DataAnnotations;
namespace Daewoo_Web_Application.Models
{
    public class PurchaseTicket
    {
        [Required(ErrorMessage = "🛈 Please select departure city.")]
        public string? Departure { get; set; }

        [Required(ErrorMessage = "🛈 Please select arrival city.")]
        public string? Arrival { get; set; }

        [Required(ErrorMessage = "🛈 Please select date.")]
        public string? Date { get; set; }
    }
}
