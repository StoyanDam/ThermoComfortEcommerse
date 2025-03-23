using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThermoComfort.Data.Models;
using ThermoComfortNew.Data;
using ThermoComfortNew.Models;

namespace ThermoComfortNew.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // Метод за показване на всички продукти
        public async Task<IActionResult> Index()
        {
            var products = _context.Products.Include(p => p.Category);
            return View(await products.ToListAsync());
        }

        // Метод за детайли на конкретен продукт
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null) return NotFound();

            return View(product);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // Метод за създаване на нов продукт
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(ProductCreateViewModel model)
        {
            // Проверка дали наличността не е отрицателна
            if (model.Availability < 0)
            {
                ModelState.AddModelError("Availability", "Наличността не може да е отрицателно число.");
            }

            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadFile(model.Image);

                var product = new Product
                {
                    ProductName = model.ProductName,
                    Description = model.Description,
                    Availability = model.Availability,
                    Characteristics = model.Characteristics,
                    Brand = model.Brand,
                    Price = model.Price,
                    CreatedOn = model.CreatedOn,
                    CategoryId = model.CategoryId,
                    ImageUrl = uniqueFileName
                };

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", model.CategoryId);
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");

            var product = await this._context.Products
                .Where(p => p.ProductId == id)
                .Select(p => new EditProductViewModel()
                {
                    ProductName = p.ProductName,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Availability = p.Availability,
                    Characteristics = p.Characteristics,
                    Brand = p.Brand,
                    Price = p.Price,
                    CategoryId = p.CategoryId,
                })
                .FirstOrDefaultAsync();

            return View(product);
        }

        // Метод за редактиране на продукт
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, EditProductViewModel model)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
            if (product == null) return NotFound();

            product.ProductName = model.ProductName;
            product.Description = model.Description;
            product.Availability = model.Availability;
            product.Characteristics = model.Characteristics;
            product.Brand = model.Brand;
            product.Price = model.Price;
            product.CategoryId = model.CategoryId;

            if (model.Image != null)
            {
                product.ImageUrl = UploadFile(model.Image);
            }

            _context.Update(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Метод за качване на изображение
        private string UploadFile(IFormFile image)
        {
            if (image == null) return null;

            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            return uniqueFileName;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null) return NotFound();

            return View(product);
        }

        // Метод за изтриване на продукт
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Проверка дали продукт съществува
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        // Метод за филтриране, сортиране и търсене на продукти
        public async Task<IActionResult> All(int? categoryId, string sortOrder, string searchTerm)
        {
            IQueryable<Product> products = _context.Products.AsQueryable();

            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.SelectedCategory = categoryId;

            if (categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.ProductName.Contains(searchTerm));
            }

            products = sortOrder switch
            {
                "price_asc" => products.OrderBy(p => p.Price),
                "price_desc" => products.OrderByDescending(p => p.Price),
                _ => products.OrderByDescending(p => p.ProductName)
            };

            return View(await products.ToListAsync());
        }
    }
}
