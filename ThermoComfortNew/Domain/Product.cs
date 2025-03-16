using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThermoComfortNew.Domain;

namespace ThermoComfort.Data.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ProductId { get; set; }

        [Required,StringLength(60)]
        [Display(Name ="Име на продукта")]
        public string ProductName { get; set; }

        [Required, StringLength(1100)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Снимка")]
        public string ImageUrl { get; set; }

        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Наличност")]
        [Range(0, int.MaxValue, ErrorMessage = "Наличността трябва да е положително число.")]
        public int Availability { get; set; }

        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }

        [Display(Name = "Марка")]
        public string Brand { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Display(Name = "Категория")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
        public virtual Category Category { get; set; }
    }
}
