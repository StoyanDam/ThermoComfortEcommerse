//using System.ComponentModel.DataAnnotations;
//using ThermoComfortNew.Domain.ThermoComfortNew.Domain;

//namespace ThermoComfortNew.Models
//{
//    public class CheckoutViewModel
//    {
//        [Required]
//        public string Address { get; set; }
//        [Required]
//        public string PhoneNumber {  get; set; }

//        public List<ShoppingCartItem> CartItems { get; set; }
//        public decimal TotalPrice { get; set; }
//    }

//}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;

public class CheckoutViewModel
{
    [Required(ErrorMessage = "Адресът е задължителен.")]
    [MaxLength(40)]
    [DisplayName("Адрес")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Телефонният номер е задължителен.")]
    [RegularExpression(@"^0\d{9}$", ErrorMessage = "Телефонният номер трябва да започва с 0 и да съдържа точно 10 цифри.")]
    [DisplayName("Телефонен номер")]
    public string PhoneNumber { get; set; }

    public List<ShoppingCartItem> CartItems { get; set; }
    public decimal TotalPrice { get; set; }
}

