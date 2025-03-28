using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.ViewModels
{
    public class ApplicationUserCreateViewModel
    {
        [Required(ErrorMessage = "Името е задължително.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилията е задължителна.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Имейлът е задължителен."), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Телефонния номер е задължителен.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна."), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
