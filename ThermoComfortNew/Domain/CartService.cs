using System.Collections.Generic;
using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using ThermoComfort.Data.Models;

    namespace ThermoComfortNew.Domain
    {
        public class CartService
        {
            private readonly List<Cart> _cartItems = new List<Cart>();

            public void AddToCart(Product product, int quantity)
            {
               
                var existingItem = _cartItems.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                }
                else
                {
                    _cartItems.Add(new Cart
                    {
                        ProductId = product.ProductId,
                        Quantity = quantity,
                        Price = product.Price
                    });
                }
            }

            public void RemoveFromCart(int productId)
            {
                var item = _cartItems.FirstOrDefault(p => p.ProductId == productId);
                if (item != null)
                {
                    _cartItems.Remove(item);
                }
            }

            public void UpdateQuantity(int productId, int quantity)
            {
                var item = _cartItems.FirstOrDefault(p => p.ProductId == productId);
                if (item != null)
                {
                    item.Quantity = quantity;
                }
            }

            public List<Cart> GetCartItems()
            {
                return _cartItems;
            }

            public void ClearCart()
            {
                _cartItems.Clear();
            }
        }
    }
}
