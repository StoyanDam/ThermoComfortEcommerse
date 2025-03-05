using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.Models
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }

        [Required, StringLength(60)]
        [Display(Name = "Име на продукта")]
        public string ProductName { get; set; }

        [Required, StringLength(1100)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Снимка")]
        public IFormFile? Image { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Наличност")]
        public int Availability { get; set; }

        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }

        [Display(Name = "Марка")]
        public string Brand { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; }
    }
}
