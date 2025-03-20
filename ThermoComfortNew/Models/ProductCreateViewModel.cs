using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.Models
{
    public class ProductCreateViewModel
    {

      
        public int ProductId { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Име на продукта")]
        public string ProductName { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Наличността не може да е отрицателно число.")]
        [Display(Name = "Наличност")]
        public int Availability { get; set; }


        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }

        [Display(Name = "Марка")]
        public string Brand { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Създаден на дата")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }
        [Display(Name = "Снимка")]
        public IFormFile Image { get; set; } // For file uploads

    }
}
