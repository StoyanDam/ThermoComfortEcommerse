//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using ThermoComfort.Data.Models;
//using ThermoComfortNew.Data;
//using ThermoComfortNew.Models;

//namespace ThermoComfortNew.Controllers
//{
//    public class ProductsController : Controller
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly IWebHostEnvironment _webHostEnvironment;

//        public ProductsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
//        {
//            _context = context;
//            _webHostEnvironment = webHostEnvironment;
//        }

//        // GET: Products
//        public async Task<IActionResult> Index()
//        {
//            var applicationDbContext = _context.Products.Include(p => p.Category);
//            return View(await applicationDbContext.ToListAsync());
//        }

//        // GET: Products/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Products
//                .Include(p => p.Category)
//                .FirstOrDefaultAsync(m => m.ProductId == id);
//            if (product == null)
//            {
//                return NotFound();
//            }

//            return View(product);
//        }

//        // GET: Products/Create
//        public IActionResult Create()
//        {
//            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");
//            return View();
//        }

//        // POST: Products/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(ProductCreateViewModel model)
//        {

//            string uniqueFileName = UploadFile(model);

//            if (ModelState.IsValid)
//            {
//                Product product = new Product
//                {
//                    ProductName = model.ProductName,
//                    Description = model.Description,
//                    Availability = model.Availability,
//                    Characteristics = model.Characteristics,
//                    Brand = model.Brand,
//                    IsDeleted = model.IsDeleted,
//                    CreatedOn = model.CreatedOn,
//                    CategoryId = model.CategoryId,
//                    Price = model.Price,
//                    ImageUrl = uniqueFileName
//                };
//                _context.Add(product);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }

//            return View(model);
//        }
//        private string UploadFile(ProductCreateViewModel model)
//        {
//            string uniqueFileName = null;
//            if (model.Image != null)
//            {
//                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
//                uniqueFileName = Guid.NewGuid().ToString() + " " + model.Image.FileName;
//                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
//                using (var fileStream = new FileStream(filePath, FileMode.Create))
//                {
//                    model.Image.CopyTo(fileStream);

//                }
//            }

//            return uniqueFileName;

//        }


//        // GET: Products/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Products.FindAsync(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", product.CategoryId);
//            return View(product);
//        }

//        // POST: Products/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("ProductName,Description,ImageUrl,Price,Availability,Characteristics,Brand,CreatedOn,IsDeleted,CategoryId")] Product product)
//        {
//            if (id != product.ProductId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(product);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ProductExists(product.ProductId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName", product.CategoryId);
//            return View(product);
//        }

//        // GET: Products/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Products
//                .Include(p => p.Category)
//                .FirstOrDefaultAsync(m => m.ProductId == id);
//            if (product == null)
//            {
//                return NotFound();
//            }

//            return View(product);
//        }

//        // POST: Products/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var product = await _context.Products.FindAsync(id);
//            if (product != null)
//            {
//                _context.Products.Remove(product);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ProductExists(int id)
//        {
//            return _context.Products.Any(e => e.ProductId == id);
//        }
//        // GET: Products/All
//        public async Task<IActionResult> All(int? categoryId, string sortOrder)
//        {
//            var products = _context.Products
//                .Where(p => !p.IsDeleted);

//            // Fetch categories for dropdown
//            ViewBag.Categories = await _context.Categories.ToListAsync();

//            // Filtering by category
//            if (categoryId.HasValue && categoryId > 0)
//            {
//                products = products.Where(p => p.CategoryId == categoryId.Value);
//            }
//            // Default sorting (Name Descending)
//            products = products.OrderByDescending(p => p.ProductName);

//            // Sorting by price (ascending) if selected
//            if (sortOrder == "price_asc")
//            {
//                products = products.OrderBy(p => p.Price);
//            }

//            return View(await products.ToListAsync());
//        }


//    }
//}


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

        public async Task<IActionResult> Index()
        {
            var products = _context.Products.Include(p => p.Category);
            return View(await products.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null) return NotFound();

            return View(product);
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateViewModel model)
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        public async Task<IActionResult> All(int? categoryId, string sortOrder, string searchTerm)
        {
            IQueryable<Product> products = _context.Products.AsQueryable(); // Ensure IQueryable

            // Fetch categories for dropdown
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.SelectedCategory = categoryId;

            // Filtering by category
            if (categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            // Filtering by search term
            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.ProductName.Contains(searchTerm));
            }

            // Sorting
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
