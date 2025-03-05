using System.ComponentModel.DataAnnotations;

namespace ThermoComfortNew.Models
{
    public class ProductCreateViewModel
    {

        //[Required, StringLength(60)]
        //[Display(Name = "Име на продукта")]
        //public string ProductName { get; set; }

        //[Required, StringLength(1100)]
        //[Display(Name = "Описание")]
        //public string Description { get; set; }

        //[Display(Name = "Снимка")]
        //public IFormFile Image { get; set; }

        //[Display(Name = "Цена")]

        //public decimal Price { get; set; }

        //[Display(Name = "Наличност")]
        //public int Availability { get; set; }

        //[Display(Name = "Характеристики")]
        //public string Characteristics { get; set; }

        //[Display(Name = "Марка")]
        //public string Brand { get; set; }

        //public DateTime CreatedOn { get; set; } = DateTime.Now;

        //public bool IsDeleted { get; set; } = false;

        //[Display(Name = "Категория")]
        //public int CategoryId { get; set; }
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        public string Description { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Availability must be a non-negative number.")]
        public int Availability { get; set; }

        public string Characteristics { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public IFormFile Image { get; set; } // For file uploads

    }
}
