using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThermoComfortNew.Data;
using ThermoComfortNew.Domain;

namespace ThermoComfortNew.Controllers
{
    [Authorize(Roles = "Admin")] // Ограничаваме достъпа до този контролер само за администратори
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            // Връща списък с всички категории
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Проверяваме дали е подаден валиден ID
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (category == null)
            {
                return NotFound(); // Проверяваме дали категорията съществува
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View(); // Зарежда формата за създаване на нова категория
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // Защита срещу CSRF атаки
        public async Task<IActionResult> Create([Bind("CategoryName,Description")] Category category)
        {
            if (ModelState.IsValid) // Проверяваме дали данните са валидни
            {
                _context.Add(category);
                await _context.SaveChangesAsync(); // Записваме новата категория в базата
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,CategoryName,Description")] Category category)
        {
            if (id != category.CategoryID)
            {
                return NotFound(); // Проверка дали ID-то съвпада
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync(); // Запазваме редактираната категория
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryID))
                    {
                        return NotFound(); // Ако категорията не съществува, връщаме грешка
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync(); // Изтриваме категорията от базата
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryID == id); // Проверка дали категорията съществува
        }
    }
}
