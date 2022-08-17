using System.ComponentModel.DataAnnotations;
namespace Daewoo_Web_Application.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "🛈 Please enter name.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,30}$", ErrorMessage = "🛈 Name should contain only alphabets.")]
        [StringLength(30)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "🛈 Please enter email.")]
        [EmailAddress(ErrorMessage = "🛈 Email is not in correct format.")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "🛈 Email is not valid.")]
        [StringLength(30)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "🛈 Please enter phone number.")]
        [Phone(ErrorMessage = "🛈 Phone number is not in correct format.")]
        [RegularExpression(@"^(03+[0-4]{1}[0-9]{8})$", ErrorMessage = "🛈 Phone number is not valid.")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "🛈 Phone Number should be 11 digits long.")]
        public string? Number { get; set; }

        [Required(ErrorMessage = "🛈 Please enter CNIC number.")]
        [RegularExpression(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$", ErrorMessage = "🛈 CNIC number is not valid.")]
        [StringLength(maximumLength: 15, MinimumLength = 15, ErrorMessage = "🛈 CNIC Number should be 13 digits long.")]
        public string? CNIC { get; set; }

        [Required(ErrorMessage = "🛈 Please enter password.")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "🛈 Password should be atleast 5 characters long.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "🛈 Please enter confirm password.")]
        [Compare("Password", ErrorMessage = "🛈 Not matched.")]
        public string? ConfirmPassword { get; set; }

    }
}