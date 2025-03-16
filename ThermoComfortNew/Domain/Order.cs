using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            [Required(ErrorMessage = "Телефонният номер е задължителен.")]
            [RegularExpression(@"^\+?\d{7,15}$", ErrorMessage = "Невалиден телефонен номер.")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Адрес")]
            public string Address { get; set; }
            
            [Display(Name = "Крайна цена")]
            public decimal TotalPrice { get; set; }

            [Display(Name = "Дата на поръчка")]
            public DateTime OrderDate { get; set; }

            [Display(Name = "Дата на доставка")]
            [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
            public DateTime DeliveryDate 
            {
                get => CalculateDeliveryDate(OrderDate).Date;
            //  set => DeliveryDate = value; You could override if needed, but the getter will auto-calculate
            }

        public bool IsPaid { get; set; }
            public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

            private DateTime CalculateDeliveryDate(DateTime orderDate)
            {
                int workingDaysToAdd = 3;
                DateTime deliveryDate = orderDate;

                // Loop until 3 working days are added
                while (workingDaysToAdd > 0)
                {
                    deliveryDate = deliveryDate.AddDays(1);
                    // Check if it's a weekday (Monday to Friday)
                    if (deliveryDate.DayOfWeek != DayOfWeek.Saturday && deliveryDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        workingDaysToAdd--;
                    }
                }

                return deliveryDate.Date;
            }
        }

    
}
