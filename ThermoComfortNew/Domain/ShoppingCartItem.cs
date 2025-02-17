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
                public string ApplicationUserId { get; set; }  // Link to the logged-in user
                public int ProductId { get; set; }
                public Product Product { get; set; }
                public int Quantity { get; set; }
            

        }


    }
}
