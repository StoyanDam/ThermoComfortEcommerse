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

        [Required, StringLength(60), Display(Name = "Категория")]
        public string? CategoryName { get; set; }

        [Display(Name = "Описание на категорията")]
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
