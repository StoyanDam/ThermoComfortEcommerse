using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.Models
{
    public class ProductCreateViewModel
    {

      
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Името е задължително.")]
        [StringLength(60)]
        [Display(Name = "Име на продукта")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Описанието е задължително.")]
        [Display(Name = "Описание")]
        public string Description { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Наличността не може да е отрицателно число.")]
        [Required(ErrorMessage = "Наличността е задължителна.")]
        [Display(Name = "Наличност")]
        public int Availability { get; set; }

        [Required(ErrorMessage = "Характеристиките са задължителни.")]
        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }

        [Required(ErrorMessage = "Марката е задължителна.")]
        [Display(Name = "Марка")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Цената е задължителна.")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Датата на създаване е задължителна.")]
        [Display(Name = "Създаден на дата")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Категорията е задължителна.")]
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Снимката е задължителна.")]
        [Display(Name = "Снимка")]
        public IFormFile Image { get; set; } // За добавяне на нови снимки

    }
}
