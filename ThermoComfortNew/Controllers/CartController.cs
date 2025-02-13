using Microsoft.AspNetCore.Mvc;
using ThermoComfort.Data.Models;
using ThermoComfortNew.Data;
using ThermoComfortNew.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ThermoComfortNew.Domain;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;

namespace ThermoComfortNew.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;
        private readonly ApplicationDbContext _context;

        public CartController(CartService cartService, ApplicationDbContext context)
        {
            _cartService = cartService;
            _context = context;
        }



        [HttpPost]
        public IActionResult AddProductToCart(int productId, int quantity = 1)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return NotFound(); // Handle the case where the product is not found
            }

            _cartService.AddToCart(product, quantity);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var cartItems = _cartService.GetCartItems();
            return View(cartItems);
        }
        //public IActionResult Index()
        //{
        //    var cartItems = _cartService.GetCartItems();
        //    return View(cartItems);
        //}


        //[HttpPost]
        //[HttpPost]
        //public IActionResult AddToCart(int productId, int quantity = 1)
        //{
        //    var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
        //    if (product == null)
        //    {
        //        return NotFound(); // Handle the case where the product is not found
        //    }

        //    _cartService.AddToCart(product, quantity);
        //    return RedirectToAction("Index");
        //}
        //[HttpPost]
        //public IActionResult AddToCart(Product product, int quantity)
        //{
        //    _cartService.AddToCart(product, quantity);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            _cartService.UpdateQuantity(productId, quantity);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            // Implement checkout logic here
            _cartService.ClearCart();
            return RedirectToAction("Index", "Home");
        }

        //За брой на елементите в количката свързан с js.
        public IActionResult GetCartItemCount()
        {
            var cartItems = _cartService.GetCartItems();
            var count = cartItems.Sum(item => item.Quantity);
            return Json(new { count });
        }
    }
}

