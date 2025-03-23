using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ThermoComfortNew.Data;
using ThermoComfortNew.Domain;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;
using ThermoComfortNew.Roles;

var builder = WebApplication.CreateBuilder(args);

// Зареждане на connection string от конфигурационния файл (appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Добавяне на контекста на базата данни с използване на SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Конфигуриране на Identity (система за управление на потребители и роли)
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>() 
    .AddEntityFrameworkStores<ApplicationDbContext>(); // Свързване с базата данни

// Конфигуриране на по-леки изисквания за пароли
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false; // Без задължителна цифра
    options.Password.RequiredLength = 5; // Минимална дължина 5 знака
    options.Password.RequireLowercase = false; // Без задължителни малки букви
    options.Password.RequireNonAlphanumeric = false; // Без задължителни специални символи
    options.Password.RequireUppercase = false; // Без задължителни големи букви
    options.Password.RequiredUniqueChars = 0; // Без задължителни уникални знаци
});

// Добавяне на сесия и достъп до HttpContext
builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession(); 
builder.Services.AddHttpContextAccessor(); 

// Добавяне на Razor Pages (използват се за страници, които не са чисти MVC контролери)
builder.Services.AddRazorPages();

// Създаване на scope за seed-ване на роли и потребители
using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        // Изпълнение на seed метода за роли и потребители
        RolesData.SeedRoles(userManager, roleManager);
    }
    catch (Exception)
    {
        throw;
    }
}

var app = builder.Build();

// Конфигуриране на middleware за обработка на заявки
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint(); // Разрешаване на миграции директно от браузъра (за разработка)
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Пренасочване към страница за грешки при проблеми в продукция
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); 

app.UseRouting();
app.UseAuthorization(); 

app.UseSession();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
