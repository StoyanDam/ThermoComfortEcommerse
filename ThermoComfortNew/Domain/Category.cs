using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Категорията е задължителна.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Категорията трябва да бъде между 3 и 60 символа.")]
        [Display(Name = "Категория")]
        public string CategoryName { get; set; }

        [StringLength(500, ErrorMessage = "Описанието не може да бъде повече от 500 символа.")]
        [Display(Name = "Описание на категорията")]
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
