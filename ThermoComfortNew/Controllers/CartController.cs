using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ThermoComfort.Data.Models;
using ThermoComfortNew.Data;
using ThermoComfortNew.Domain;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;
using ThermoComfortNew.Models;

public class CartController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public CartController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // Показване на всички продукти в количката на текущия потребител
    [Authorize]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var cartItems = await _context.ShoppingCartItems
            .Include(c => c.Product)
            .Where(c => c.ApplicationUserId == user.Id)
            .ToListAsync();

        return View(cartItems);
    }

    // Добавяне на продукт в количката
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
    {
        var user = await _userManager.GetUserAsync(User);
        var cartItem = await _context.ShoppingCartItems
            .FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id && c.ProductId == productId);

        if (cartItem == null)
        {
            // Ако продуктът не е в количката, създаваме нов запис
            _context.ShoppingCartItems.Add(new ShoppingCartItem
            {
                ApplicationUserId = user.Id,
                ProductId = productId,
                Quantity = quantity
            });
        }
        else
        {
            // Ако вече съществува, увеличаваме количеството
            cartItem.Quantity += quantity;
        }

        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    // Премахване на продукт от количката
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> RemoveFromCart(int id)
    {
        var cartItem = await _context.ShoppingCartItems.FindAsync(id);
        if (cartItem != null)
        {
            _context.ShoppingCartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }

    // Показване на страницата за финализиране на поръчката
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Checkout()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Index", "Home");

        var cartItems = await _context.ShoppingCartItems
            .Where(c => c.ApplicationUserId == user.Id)
            .Include(c => c.Product)
            .ToListAsync();

        if (!cartItems.Any())
        {
            TempData["Message"] = "Вашата количка е празна.";
            return RedirectToAction("Index");
        }

        var viewModel = new CheckoutViewModel
        {
            CartItems = cartItems,
            TotalPrice = cartItems.Sum(i => i.Product.Price * i.Quantity)
        };

        return View(viewModel);
    }

    // Финализиране на поръчката
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Checkout(string address, string phoneNumber)
    {
        var user = await _userManager.GetUserAsync(User);
        var cartItems = await _context.ShoppingCartItems
            .Where(c => c.ApplicationUserId == user.Id)
            .Include(c => c.Product)
            .ToListAsync();

        if (!cartItems.Any())
        {
            TempData["Error"] = "Вашата количка е празна.";
            return RedirectToAction("Index");
        }

        // Проверка за наличност на продуктите
        foreach (var cartItem in cartItems)
        {
            if (cartItem.Product.Availability < cartItem.Quantity)
            {
                TempData["Error"] = $"Недостатъчна наличност за '{cartItem.Product.ProductName}'. Налични: {cartItem.Product.Availability} броя.";
                return RedirectToAction("Index");
            }
        }

        var order = new Order
        {
            ApplicationUserId = user.Id,
            Address = address,
            PhoneNumber = phoneNumber,
            OrderDate = DateTime.Now,
            IsPaid = true,
            TotalPrice = cartItems.Sum(c => c.Product.Price * c.Quantity),
            OrderProducts = cartItems.Select(c => new OrderProduct
            {
                ProductId = c.ProductId,
                Quantity = c.Quantity
            }).ToList()
        };

        _context.Orders.Add(order);

        // Намаляване на наличността на продуктите
        foreach (var cartItem in cartItems)
        {
            var product = await _context.Products.FindAsync(cartItem.ProductId);
            if (product != null)
            {
                product.Availability -= cartItem.Quantity;
            }
        }

        _context.ShoppingCartItems.RemoveRange(cartItems); // Изчистване на количката след завършване на поръчката
        await _context.SaveChangesAsync();

        TempData["Success"] = "Вашата поръчка е успешно направена!";
        return RedirectToAction("Index", "Orders");
    }

    // Връща броя на продуктите в количката като JSON
    [HttpGet]
    public async Task<IActionResult> GetCartCount()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
        {
            return Json(new { count = 0 });
        }

        var cartCount = await _context.ShoppingCartItems
            .Where(c => c.ApplicationUserId == userId)
            .SumAsync(c => c.Quantity);

        return Json(new { count = cartCount });
    }
}
