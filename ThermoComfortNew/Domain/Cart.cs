using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    public class Cart
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
