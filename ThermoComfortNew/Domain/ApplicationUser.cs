using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
            Orders = new List<Order>();
        }

        [Required(ErrorMessage = "Името е задължително.")]
        [StringLength(50, ErrorMessage = "Името не може да надвишава 50 символа.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилията е задължителна.")]
        [StringLength(50, ErrorMessage = "Фамилията не може да надвишава 50 символа.")]
        public string LastName { get; set; }


        [Display(Name = "Пълно име")]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        [Required(ErrorMessage = "Имейлът е задължителен.")]
        [EmailAddress(ErrorMessage = "Невалиден имейл адрес.")]
        [Display(Name = "Email")]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Телефонният номер е задължителен.")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Телефонният номер трябва да започва с 0 и да съдържа точно 10 цифри.")]
        public override string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
