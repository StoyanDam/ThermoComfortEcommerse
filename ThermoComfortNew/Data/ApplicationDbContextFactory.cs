namespace ThermoComfortNew.Data
{
    // Импортиране на необходими библиотеки
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    // Този клас се използва при миграции и разработка, когато няма достъпен DI (Dependency Injection)
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        // Методът CreateDbContext създава инстанция на ApplicationDbContext
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Зареждане на конфигурацията от appsettings.json (или други източници като променливи на средата)
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Определя текущата директория като базова
                .AddJsonFile("appsettings.json", optional: false) // Добавя appsettings.json като конфигурационен файл (не може да бъде пропуснат)
                .Build(); // Изгражда конфигурацията

            // Извличане на connection string за базата данни от конфигурационния файл
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Създаване на DbContextOptionsBuilder за конфигуриране на ApplicationDbContext
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString); // Задаване на SQL Server като база данни

            // Връща нова инстанция на ApplicationDbContext с конфигурирани опции
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
