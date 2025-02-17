using System.ComponentModel.DataAnnotations;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;

namespace ThermoComfortNew.Models
{
    public class CheckoutViewModel
    {
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber {  get; set; }

        public List<ShoppingCartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
