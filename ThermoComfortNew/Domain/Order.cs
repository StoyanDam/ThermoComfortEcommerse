using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThermoComfortNew.Domain;

namespace ThermoComfort.Data.Models
{
    public class Order
    {
        // Уникален идентификатор за поръчката
        [Key]
        public int Id { get; set; }
   
        [Display(Name = "Потребител")]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Тел. номер")]
        [Required(ErrorMessage = "Телефонният номер е задължителен.")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Телефонният номер трябва да започва с 0 и да съдържа точно 10 цифри.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Крайна цена")]
        public decimal TotalPrice { get; set; }

    
        [Display(Name = "Дата на поръчка")]
        public DateTime OrderDate { get; set; }

        // Дата на доставка (изчислява се автоматично)
        [Display(Name = "Дата на доставка")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DeliveryDate
        {
            get => CalculateDeliveryDate(OrderDate).Date; // Взема изчислената дата на доставка
        }
 
        public bool IsPaid { get; set; }

        // Списък с продуктите, които са част от поръчката (много към много релация)
        public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

        // Метод за изчисляване на датата на доставка (3 работни дни след поръчката)
        private DateTime CalculateDeliveryDate(DateTime orderDate)
        {
            int workingDaysToAdd = 3; // Определяме броя работни дни
            DateTime deliveryDate = orderDate;

            // Обхождаме дните, докато не добавим 3 работни дни
            while (workingDaysToAdd > 0)
            {
                deliveryDate = deliveryDate.AddDays(1); // Добавяме ден
                // Проверяваме дали денят е работен (Понеделник-Петък)
                if (deliveryDate.DayOfWeek != DayOfWeek.Saturday && deliveryDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDaysToAdd--; // Намаляваме броя на оставащите работни дни
                }
            }

            return deliveryDate.Date; // Връщаме само датата без часове
        }
    }
}
