using System.Collections.Generic;
using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using ThermoComfort.Data.Models;

    namespace ThermoComfortNew.Domain
    {
        public class ShoppingCartItem
        {
           
                public int Id { get; set; }
                public string ApplicationUserId { get; set; }  // Връзка към потребителя, влязъл в акаунта си
                public int ProductId { get; set; }
                public Product Product { get; set; }
                public int Quantity { get; set; }
            

        }


    }
}
