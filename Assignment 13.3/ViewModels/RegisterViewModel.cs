using System.ComponentModel.DataAnnotations;
namespace Assignment_13._3.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
