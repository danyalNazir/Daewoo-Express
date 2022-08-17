using System.ComponentModel.DataAnnotations;
namespace Daewoo_Web_Application.Models
{
    public class Suggestion
    {
        [Required(ErrorMessage = "🛈 Please select status.")]
        public string? Suggestion_Status { get; set; }

        [Required(ErrorMessage = "🛈 Please select suggestion type.")]
        public string? Suggestion_Type { get; set; }

        [Required(ErrorMessage = "🛈 Please enter suggestion title.")]
        public string? Suggestion_Title { get; set; }

        [Required(ErrorMessage = "🛈 Please enter name.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,30}$", ErrorMessage = "🛈 Name should contain only alphabets.")]
        [StringLength(30)]
        public string? UserName  { get; set; }

        [Required(ErrorMessage = "🛈 Please enter email.")]
        [EmailAddress(ErrorMessage = "🛈 Email is not in correct format.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "🛈 Email is not valid.")]
        [StringLength(30)]
        public string? Email  { get; set; }

        [Required(ErrorMessage = "🛈 Please enter phone number.")]
        [Phone(ErrorMessage = "🛈 Phone number is not in correct format.")]
        [RegularExpression(@"^(03+[0-4]{1}[0-9]{8})$", ErrorMessage = "🛈 Phone number is not valid.")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "🛈 Phone Number should be 11 digits long.")]
        public string? Number { get; set; }

        [Required(ErrorMessage = "🛈 Please enter your message.")]
        [StringLength(350)]
        public string? Message { get; set; }

    }
}
