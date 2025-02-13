using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ThermoComfort.Data.Models;
using ThermoComfortNew.Data;
using ThermoComfortNew.Domain;

namespace ThermoComfortNew.Controllers
{
    public class ApplicationUsersController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly ApplicationDbContext _data;

        //public ApplicationUsersController(UserManager<ApplicationUser> userManager, ApplicationDbContext data)
        //{
        //    this._userManager = userManager;
        //    this._data = data;
        //}

        //[HttpGet]
        //[Authorize]
        //public async Task<IActionResult> Details()
        //{
        //    var user = await this._userManager.GetUserAsync(User);

        //    var model = new ApplicationUser()
        //    {
        //        Email = user.Email,
        //        Id = user.Id,
        //        FirstName = user.FirstName,
        //        LastName = user.LastName
        //    };

        //    return this.View(model);
        //}

        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        //public IActionResult All()
        //{
        //    var users = this._data.Users
        //        .Select(u => new ApplicationUser()
        //        {
        //            Id = u.Id,
        //            FirstName = u.FirstName,
        //            LastName = u.LastName,
        //            Email = u.Email
        //        })
        //        .ToList();

        //    return View(users);
        //}

        //[HttpGet]
        //[Authorize]
        //public IActionResult Edit(string id)
        //{
        //    if (!this.User.IsInRole("Admin") || id == null)
        //    {
        //        id = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //    }

        //    var user = this._data.Users
        //        .Where(u => u.Id == id)
        //        .Select(u => new ApplicationUser()
        //        {
        //            Id = u.Id,
        //            FirstName = u.FirstName,
        //            LastName = u.LastName,
        //            Email = u.Email
        //        })
        //        .Single();

        //    return View(user);
        //}

        //[HttpPost]
        //[Authorize]
        //public IActionResult Update(string id, ApplicationUser input)
        //{
        //    if (!this.User.IsInRole("Admin"))
        //    {
        //        id = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //    }

        //    var user = this._data.Users
        //        .FirstOrDefault(u => u.Id == id);

        //    user.FirstName = input.FirstName;
        //    user.LastName = input.LastName;
        //    user.Email = input.Email;
        //    user.NormalizedEmail = input.Email.ToUpper();
        //    user.UserName = input.Email;
        //    user.UserName = input.Email.ToUpper();

        //    this._data.SaveChanges();

        //    return RedirectToAction("Index", "Home");
        //}

        //[HttpPost]
        //[Authorize(Roles = "Admin")]
        //public IActionResult Delete(string id)
        //{
        //    foreach (var review in this._data.Reviews.Where(r => r.UserId == id))
        //    {
        //        this._data.Reviews.Remove(review);
        //    }

        //    foreach (var order in this._data.Orders.Where(o => o.ApplicationUserId == id))
        //    {
        //        foreach (var orderProduct in this._data.OrderProducts.Where(op => op.OrderId == order.Id))
        //        {
        //            this._data.OrderProducts.Remove(orderProduct);
        //        }

        //        this._data.Orders.Remove(order);
        //    }

        //    var user = this._data.Users
        //        .FirstOrDefault(u => u.Id == id);

        //    this._data.Users.Remove(user);
        //    this._data.SaveChanges();

        //    return RedirectToAction("Index", "Home");
        //}

        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        //public IActionResult Add()
        //    => View();

        //[HttpPost]
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> Create(ApplicationUser input)
        //{
        //    var user = new ApplicationUser
        //    {
        //        UserName = input.Email,
        //        Email = input.Email,
        //        FirstName = input.FirstName,
        //        LastName = input.LastName
        //    };

        //    await _userManager.CreateAsync(user, input.Password);

        //    return RedirectToAction("All");
        //}

        //[HttpGet]
        //[Authorize]
        //public async Task<IActionResult> Orders()
        //{
        //    var orders = await this._data.Orders
        //        .Where(o => o.ApplicationUserId == this.User.FindFirst(ClaimTypes.NameIdentifier).Value)
        //        .Select(o => new Order()
        //        {
        //            Id = o.Id,
        //            TotalPrice = o.TotalPrice,
        //            PhoneNumber = o.PhoneNumber,
        //            ApplicationUserId = o.ApplicationUserId,
        //            ApplicationUser = this._data.Users
        //                .Where(u => u.Id == o.ApplicationUserId)
        //                .Select(u => new ApplicationUser()
        //                {
        //                    Id = u.Id,
        //                    FirstName = u.FirstName,
        //                    LastName = u.LastName,
        //                    Email = u.Email
        //                })
        //                .SingleOrDefault(),
        //            OrderProducts = new List<Product>()
        //        })
        //        .ToListAsync();

        //    foreach (var order in orders)
        //    {
        //        var orderProducts = await this._data.OrderProducts
        //            .Where(op => op.OrderId == order.Id)
        //            .ToListAsync();

        //        foreach (var orderProduct in orderProducts)
        //        {
        //            var product = await this._data.Products
        //                .Where(p => p.ProductId == orderProduct.ProductId)
        //                .Select(product => new Product()
        //                {
        //                    Brand = product.Brand,
        //                    Description = product.Description,
        //                    ProductId = product.ProductId,
        //                    ImageUrl = product.ImageUrl,
        //                    ProductName = product.ProductName,
        //                    Price = product.Price,
        //                    Characteristics = product.Characteristics,
        //                    Availability = product.Availability,


        //                })
        //                .FirstOrDefaultAsync();

        //            order.Products.Add(product);
        //        }
        //    }

        //    return this.View(orders);
        //}

        private readonly ApplicationDbContext _context;

        public ApplicationUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ApplicationUsers
        public async Task<IActionResult> All()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: ApplicationUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Orders)
                .Include(u => u.Reviews)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: ApplicationUsers/Create
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicationUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,PhoneNumber")] ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: ApplicationUsers/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: ApplicationUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, [Bind("Id,FirstName,LastName,Email,PhoneNumber")] ApplicationUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: ApplicationUsers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: ApplicationUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

