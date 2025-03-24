using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.ViewModels
{
    public class ApplicationUserCreateViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
