using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.Models
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Името е задължително"), StringLength(60)]
        [Display(Name = "Име на продукта")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Описанието е задължително."), StringLength(1100)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Снимка")]
        public IFormFile? Image { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Наличността не може да е отрицателно число.")]
        [Display(Name = "Наличност")]
        public int Availability { get; set; }

        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }

        [Display(Name = "Марка")]
        public string Brand { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; } //Пазим пътя на старата снимка
    }
}
