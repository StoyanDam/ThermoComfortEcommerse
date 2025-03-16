using Azure.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThermoComfort.Data.Models;
using ThermoComfortNew.Domain;
using ThermoComfortNew.Domain.ThermoComfortNew.Domain;

namespace ThermoComfortNew.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           





            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Термопомпи", Description = "Термопомпата е устройство, което използва енергия от външната среда (въздух, вода или земя), за да отоплява или охлажда сгради. " },
                new Category { CategoryID = 2, CategoryName = "Газови котли", Description = "Газовите котли са отоплителни уреди, които използват природен газ или пропан-бутан за затопляне на вода, която циркулира в радиатори, подово отопление или битова гореща вода (БГВ)" },
                new Category { CategoryID = 3, CategoryName = "Пелетни камини", Description = "Пелетните камини са отоплителни уреди, които използват дървесни пелети като гориво. Те работят автоматично, като подават пелетите в горивната камера чрез шнек и регулират горенето с вентилатор и електроника." },
                new Category { CategoryID = 4, CategoryName = "Климатици", Description = "Климатикът е уред, който охлажда, отоплява и регулира влажността на въздуха в затворени помещения. Работи чрез топлообменен процес, при който прехвърля топлина от едно място на друго с помощта на хладилен агент (фреон)." }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Термопомпа Mitsubishi Electric Power Inverter",
                    Description = "Термопомпената система се състои от следните компоненти:\r\n\r\nвъншно тяло\r\nвътрешно тяло Hydrobox\r\nмодул за управление.",
                    ImageUrl = "termopompa1.jpg",
                    Price = 23209.99m,
                    Availability = 5,
                    Characteristics = " Вид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R410a\r\nМощност kW: 10 - 12 kW\r\nРаботен режим: Само Отопление\r\nРаботна температура: Нискотемпературна до 65°C",
                    Brand = "Mitsubishi",
                    CreatedOn = DateTime.Now,
                    CategoryId = 1
                },

            new Product
            {
                ProductId = 2,
                ProductName = "Термопомпа Daikin Altherma 3",
                Description = "Нискотемпературна термопомпа + 230 литров бойлер\r\n› Комбиниран вътрешен модул с вграден неръждаем бойлер 180 или 230 литра и термопомпа за лесен монтаж\r\n› Всички хидравлични компоненти са включени - не са необходими външни компоненти\r\n› Електрическите и хидравлични компоненти са в предната част за лесен достъп\r\n› Компактни размери - отпечатък 595х625 mm\r\n› Вграден помощен нагревател 6 или 9 kW\r\n› Работа в термопомпен режим до -25°C​\r\n› Съвместима с Onecta и гласов контрол​",
                ImageUrl = "termopompa2.jpg",
                Price = 15210.12m,
                Availability = 8,
                Characteristics = " Обем в литри: 230 л.\r\nВид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C",
                Brand = "Daikin ",
                CreatedOn = DateTime.Now,
                CategoryId = 1
            },
             new Product
             {
                 ProductId = 3,
                 ProductName = "Термопомпа Immergas Magis Pro 14 V2 T",
                 Description = "ИДЕАЛНА ЗАЩИТА ОТ ЗАМРЪЗВАНЕ Хидравличният модул е напълно защитен от замръзване, поради разположението му вътре в жилището;\r\nКОМПАКТНО РЕШЕНИЕ Обединява в отделния хидравличен модул основните компоненти на хидравличната инсталация, а именно: комплект нагреватели за инсталацията (опция), разширителен съд, 3-пътен превключващ вентил за БГВ, хидравлична група с циркулационна помпа и комплект нагреватели за системата (опция) - до 2 - за версии 12, 14 и 16.\r\nЗАПАЗВАНЕ НА ЕСТЕТИКАТА Външното тяло е по-компактно, което осигурява по-голяма гъвкавост при инсталация на фасадите извън сградата или на тераса.\r\nЛЕСЕН МОНТАЖ Професионалистът може да използва MAGIS PRO V2 като автономно решение за отопление, охлаждане и битова гореща вода или като решениe за интегриране в инсталационни табла и инсталационни табла за вграждане в стена.",
                 ImageUrl = "termopompa3.jpg",
                 Price = 15650.53m,
                 Availability = 15,
                 Characteristics = " Вид Термопомпа: Сплит\r\nЗахранване: 380V\r\nХладилен Агент: R410a\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nЕнергиен клас охлаждане: A+",
                 Brand = "Immergas ",
                 CreatedOn = DateTime.Now,
                 CategoryId = 1
             },

              new Product
              {
                  ProductId = 4,
                  ProductName = "Термопомпа Samsung ClimateHub Mono",
                  Description = "ClimateHub Mono\r\n– ​Интегрирано решение за отопление и битова гореща вода.\r\n– ​Компактен размер с голям бойлер за битова гореща вода (200 L и 260 L).\r\n– ​Интуитивен, сензорен контролер с цветен екран на няколко езика.\r\n– ​Проследяване на консумираната енергия чрез сензорен контролер.\r\n– ​Безпроблемно обслужване през сервизен прозорец в предната част.\r\n– ​Готовност за включване към фотоволтаици и Smart Grid.\r\n– ​2-зоново управление, подходящо за подово и радиаторно отопление.\r\n– ​Клас на SCOP A+++.\r\n– ​SmartThings система, съвместима с Wi-Fi комплект, предлаган като опция.\r\n– ​За осигуряване на минимална температура на водата е включен резервен нагревател",
                  ImageUrl = "termopompa-4.jpg",
                  Price = 20800.50m,
                  Availability = 3,
                  Characteristics = " Обем в литри: 260 л.\r\nВид Термопомпа: Сплит с вграден водосъдържател\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C",
                  Brand = "Samsung ",
                  CreatedOn = DateTime.Now,
                  CategoryId = 1
              },
               new Product
               {
                   ProductId = 5,
                   ProductName = "Термопомпа Toshiba Estia",
                   Description = "Иновативна гама термопомпи. Компактен, ефективен и тих хиромодул. А+++ енергиен клас отопление. Серия ESTIA R32. Опция за свързване с WiFi. Удобни дистанционни управления. Произход Полша.",
                   ImageUrl = "termopompa5.jpg",
                   Price = 9318.98m,
                   Availability = 18,
                   Characteristics = "Вид Термопомпа: Сплит\r\nТип инвертор: Инвертор\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nНиво на шум: 26 - 30dB\r\nWi-Fi: Да\r\nЦвят: Бял",
                   Brand = "Toshiba  ",
                   CreatedOn = DateTime.Now,
                   CategoryId = 1
               },
                  new Product
                  {
                      ProductId = 6,
                      ProductName = "Газов котел Immergas VICTRIX 35 kW TT",
                      Description = "Повече комфорт със стенния двуконтурен комбиниран кондензен котел VICTRIX. Газовите котли на Immergas отговарят на новите Европейски Директиви за използване на енергия, фокусирани върху кондензната технология. Произведени в Италия. Лесни за инсталация във всяко пространство. Ново поколение котли подходящи за нови и стари вече изградени отоплителни инсталации. Всички модели притежават модулационна циркулационна помпа с нисък разход, за достигане на висока енергийна ефективност. ",
                      ImageUrl = "gazov-kotel1.jpg",
                      Price = 3569.90m,
                      Availability = 18,
                      Characteristics = "Максимална термична мощност\r\n(за БГВ) - 34.9 kW\r\n(за отопление) - 32.7 kW\r\nМинимална термична мощност - 4.0 kW\r\nМаксимална топлинна мощност\r\n(за БГВ) - 34.2 kW\r\n(за отопление) - 32.0 kW\r\nМинимална топлинна мощност - 3.9 kW\r\nЕфективност при:\r\nноминална мощност 80/60°C  -  97.8 %\r\n30% натоварване 80/60°C  -  103.2 %\r\nноминална мощност 40/30°C  -  106.2 %\r\n30% натоварване 40/30°C  -  108.2 %\r\nДебит на газ при горелката (метан) макс./мин. - 3.69 / 0.43 m³/h",
                      Brand = "Immergas ",
                      CreatedOn = DateTime.Now,
                      CategoryId = 2
                  },

                  new Product
                  {
                      ProductId = 7,
                      ProductName = "Газов котел Immergas VICTRIX Tera 24 V2 Plus",
                      Description = "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.",
                      ImageUrl = "gazov-kotel2.jpg",
                      Price = 2468.00m,
                      Availability = 10,
                      Characteristics = "Термична мощност: Макс. (режим БГВ): 28.7 kW; Макс. (режим отопление): 24.5 kW; Мин.: 4.5 kW",
                      Brand = "Immergas",
                      CreatedOn = DateTime.Now,
                      CategoryId = 2
                  },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Газов котел Immergas VICTRIX Tera 35 V2 Plus",
                    Description = "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.",
                    ImageUrl = "gazov-kotel3.jpg",
                    Price = 3228.00m,
                    Availability = 8,
                    Characteristics = "Термична мощност: Макс. (режим БГВ): 34.8 kW; Макс. (режим отопление): 30.5 kW; Мин.: 4.5 kW",
                    Brand = "Immergas",
                    CreatedOn = DateTime.Now,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Газов котел Bosch Condens 2500W",
                    Description = "Bosch Condens 2500W WBC 28-1 DCE 23 - двуконтурен газов кондензен котел с мощност 3,7-28KW. Работи на принципа на  т. нар. кондензна техника – използва  както топлината, която възниква като измерима температура при процес на горене, така и  топлината от кондензацията на водните пари в отработените газове. ",
                    ImageUrl = "gazov-kotel4.png",
                    Price = 2479.00m,
                    Availability = 5,
                    Characteristics = "Енергиен клас\t\r\nA++/A++\r\n\r\nГаранция\t\r\nдо 24 месеца\r\n\r\nМаксимална ел. консумация\t\r\n94 W\r\n\r\nМощност при 40/30°C-kW\t\r\n4,1 - 25,4\r\n\r\nМощност при 50/30°C-kW\t\r\n3,3 - 25,2\r\n\r\nМощност при 80/30°C-kW\t\r\n3,7 - 24,1\r\n\r\nПроизводител\t\r\nBosch",
                    Brand = "Bosch",
                    CreatedOn = DateTime.Now,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "Газов котел Viessmann Vitodens 100-W ",
                    Description = "Газов котел Viessmann Vitodens 100-W B1HC301 отговаря напълно на изискванията за енергийна ефективност заложени в Програмата за кредитиране на енергийната ефективност в дома. Vitodens 100-W е високоефективен стенен газов кондензен котел на изключително атрактивна цена и с безкомпромисното качество.",
                    ImageUrl = "gazov-kotel5.jpg",
                    Price = 3369.00m,
                    Availability = 7,
                    Characteristics = "Стенен кондензен газов котел Viessmann Vitodens 100-W от 19 до 35 kW, едноконтурен;\r\nКоефициент на ефективност до 98% (Hs)/109% (Hi);\r\nИнтегриран мембранен разширитвисокоефективна работа с пълноценно използване на топлината от конденза;\r\nВентилатор с регулиране на оборотите за тиха и енергоспестяваща работа;\r\nМодулираща цилидрична горелка MatriX;\r\nВисокоефективна помпа;\r\nУправление по константна или по външна температура;\r\nНов осветен LCD-Touch дисплей за лесно и комфортно обслужване;",
                    Brand = "Viessmann",
                    CreatedOn = DateTime.Now,
                    CategoryId = 2
                },
               new Product
               {
                   ProductId = 11,
                   ProductName = "Стенен климатик Daikin FTXF25C/RXF25C",
                   Description = "Енергийно ефективен стенен климатик с модерен дизайн и тиха работа. Подходящ за помещения до 25 кв.м.",
                   ImageUrl = "klimatik1.jpg",
                   Price = 1399.00m,
                   Availability = 15,
                   Characteristics = "Мощност охлаждане: 2.5 kW; Мощност отопление: 2.8 kW; Енергиен клас: A++; Ниво на шум: 21 dB",
                   Brand = "Daikin",
                   CreatedOn = DateTime.Now,
                   CategoryId = 4
               },
                new Product
                {
                    ProductId = 12,
                    ProductName = "Стенен климатик Mitsubishi Electric MSZ-HR25VF/MUZ-HR25VF",
                    Description = "Компактен и стилен стенен климатик с висока енергийна ефективност и тих режим на работа.",
                    ImageUrl = "klimatik2.jpeg",
                    Price = 1249.00m,
                    Availability = 10,
                    Characteristics = "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.15 kW; Енергиен клас: A+; Ниво на шум: 22 dB",
                    Brand = "Mitsubishi Electric",
                    CreatedOn = DateTime.Now,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 13,
                    ProductName = "Стенен климатик Fujitsu ASYG09LMCE/AOYG09LMCE",
                    Description = "Високоефективен стенен климатик с компактен дизайн и ниско ниво на шум. Идеален за малки помещения.",
                    ImageUrl = "klimatik3.webp",
                    Price = 1099.00m,
                    Availability = 12,
                    Characteristics = "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 20 dB",
                    Brand = "Fujitsu",
                    CreatedOn = DateTime.Now,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 14,
                    ProductName = "Стенен климатик Toshiba RAS-B10J2KVG-E/RAS-10J2AVG-E",
                    Description = "Елегантен стенен климатик с висока енергийна ефективност и пречистване на въздуха. Подходящ за средни помещения.",
                    ImageUrl = "klimatik4.png",
                    Price = 1299.00m,
                    Availability = 8,
                    Characteristics = "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 21 dB",
                    Brand = "Toshiba",
                    CreatedOn = DateTime.Now,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId =15,
                    ProductName = "Стенен климатик Gree GWH09AAB-K6DNA1A",
                    Description = "Надежден стенен климатик с инверторна технология и ниско ниво на шум. Идеален за спални и малки офиси.",
                    ImageUrl = "klimatik5.png",
                    Price = 999.00m,
                    Availability = 20,
                    Characteristics = "Мощност охлаждане: 2.6 kW; Мощност отопление: 2.9 kW; Енергиен клас: A+; Ниво на шум: 22 dB",
                    Brand = "Gree",
                    CreatedOn = DateTime.Now,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 16,
                    ProductName = "Камина на пелети MIA IDRO",
                    Description = "Автоматична камина на пелети с водна риза, оборудвана с електронна циркулационна помпа, разширителен съд и седмичен програматор.",
                    ImageUrl = "kamina1.jpg",
                    Price = 3430.00m,
                    Availability = 5,
                    Characteristics = "Мощност: 15 kW; КПД: 91%; Вместимост на бункера: 20 кг; Консумация на пелети: 1.1 - 3.3 кг/ч; Тегло: 150 кг",
                    Brand = "MIA",
                    CreatedOn = DateTime.Now,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 17,
                    ProductName = "Камина на пелети DI CALORE",
                    Description = "Камина на пелети с водна риза, произведена с италиански компоненти, осигуряваща висока ефективност и надеждност.",
                    ImageUrl = "kamina2.png",
                    Price = 2904.00m,
                    Availability = 8,
                    Characteristics = "Мощност: 18 kW; КПД: 92%; Вместимост на бункера: 25 кг; Консумация на пелети: 1.2 - 3.8 кг/ч; Тегло: 160 кг",
                    Brand = "DI CALORE",
                    CreatedOn = DateTime.Now,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 18,
                    ProductName = "Камина на пелети BURNIT Advant B2",
                    Description = "Пелетна камина с водна риза, оборудвана с вградена циркулационна помпа, разширителен съд и интелигентно управление.",
                    ImageUrl = "kamina3.jpg",
                    Price = 3369.65m,
                    Availability = 10,
                    Characteristics = "Мощност: 20 kW; КПД: 90%; Вместимост на бункера: 30 кг; Консумация на пелети: 1.5 - 4.5 кг/ч; Тегло: 170 кг",
                    Brand = "BURNIT",
                    CreatedOn = DateTime.Now,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 19,
                    ProductName = "Камина на пелети BURNIT Advant",
                    Description = "Ефективна камина на пелети с водна риза, подходяща за отопление на средни и големи помещения.",
                    ImageUrl = "kamina4.png",
                    Price = 3369.65m,
                    Availability = 7,
                    Characteristics = "Мощност: 25 kW; КПД: 91%; Вместимост на бункера: 35 кг; Консумация на пелети: 1.8 - 5.0 кг/ч; Тегло: 180 кг",
                    Brand = "BURNIT",
                    CreatedOn = DateTime.Now,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 20,
                    ProductName = "Камина на пелети BURNIT Calor",
                    Description = "Стилна камина на пелети с водна риза, осигуряваща ефективно отопление и лесно управление.",
                    ImageUrl = "kamina5.png",
                    Price = 3953.90m,
                    Availability = 6,
                    Characteristics = "Мощност: 22 kW; КПД: 92%; Вместимост на бункера: 28 кг; Консумация на пелети: 1.4 - 4.2 кг/ч; Тегло: 160 кг",
                    Brand = "BURNIT",
                    CreatedOn = DateTime.Now,
                    CategoryId = 3
                }
            );

        }
    }
}
