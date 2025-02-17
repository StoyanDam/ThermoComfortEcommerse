using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThermoComfort.Data.Models
{
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Поръчка")]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Orders { get; set; }
        [Display(Name = "Продукт")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
