using System.ComponentModel.DataAnnotations;
using ThermoComfortNew.Domain;

namespace ThermoComfort.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Потребител")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Тел. номер")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Адрес")]
        public string Address{ get; set; }
        [Display(Name = "Крайна цена")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Дата на поръчка")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Дата на доставка")]
        public DateTime DeliveryDate { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
}
