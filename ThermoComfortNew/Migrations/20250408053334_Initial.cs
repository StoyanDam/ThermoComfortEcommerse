using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThermoComfortNew.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1100)", maxLength: 1100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Термопомпи", "Термопомпата е устройство, което използва енергия от външната среда (въздух, вода или земя), за да отоплява или охлажда сгради. " },
                    { 2, "Газови котли", "Газовите котли са отоплителни уреди, които използват природен газ или пропан-бутан за затопляне на вода, която циркулира в радиатори, подово отопление или битова гореща вода (БГВ)" },
                    { 3, "Пелетни камини", "Пелетните камини са отоплителни уреди, които използват дървесни пелети като гориво. Те работят автоматично, като подават пелетите в горивната камера чрез шнек и регулират горенето с вентилатор и електроника." },
                    { 4, "Климатици", "Климатикът е уред, който охлажда, отоплява и регулира влажността на въздуха в затворени помещения. Работи чрез топлообменен процес, при който прехвърля топлина от едно място на друго с помощта на хладилен агент (фреон)." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Availability", "Brand", "CategoryId", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 5, "Mitsubishi", 1, " Вид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R410a\r\nМощност kW: 10 - 12 kW\r\nРаботен режим: Само Отопление\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2456), "Термопомпената система се състои от следните компоненти:\r\n\r\nвъншно тяло\r\nвътрешно тяло Hydrobox\r\nмодул за управление.", "termopompa1.jpg", 23209.99m, "Термопомпа Mitsubishi Electric Power Inverter" },
                    { 2, 8, "Daikin ", 1, " Обем в литри: 230 л.\r\nВид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2471), "Нискотемпературна термопомпа + 230 литров бойлер\r\n› Комбиниран вътрешен модул с вграден неръждаем бойлер 180 или 230 литра и термопомпа за лесен монтаж\r\n› Всички хидравлични компоненти са включени - не са необходими външни компоненти\r\n› Електрическите и хидравлични компоненти са в предната част за лесен достъп\r\n› Компактни размери - отпечатък 595х625 mm\r\n› Вграден помощен нагревател 6 или 9 kW\r\n› Работа в термопомпен режим до -25°C​\r\n› Съвместима с Onecta и гласов контрол​", "termopompa2.jpg", 15210.12m, "Термопомпа Daikin Altherma 3" },
                    { 3, 15, "Immergas ", 1, " Вид Термопомпа: Сплит\r\nЗахранване: 380V\r\nХладилен Агент: R410a\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nЕнергиен клас охлаждане: A+", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2482), "ИДЕАЛНА ЗАЩИТА ОТ ЗАМРЪЗВАНЕ Хидравличният модул е напълно защитен от замръзване, поради разположението му вътре в жилището;\r\nКОМПАКТНО РЕШЕНИЕ Обединява в отделния хидравличен модул основните компоненти на хидравличната инсталация, а именно: комплект нагреватели за инсталацията (опция), разширителен съд, 3-пътен превключващ вентил за БГВ, хидравлична група с циркулационна помпа и комплект нагреватели за системата (опция) - до 2 - за версии 12, 14 и 16.\r\nЗАПАЗВАНЕ НА ЕСТЕТИКАТА Външното тяло е по-компактно, което осигурява по-голяма гъвкавост при инсталация на фасадите извън сградата или на тераса.\r\nЛЕСЕН МОНТАЖ Професионалистът може да използва MAGIS PRO V2 като автономно решение за отопление, охлаждане и битова гореща вода или като решениe за интегриране в инсталационни табла и инсталационни табла за вграждане в стена.", "termopompa3.jpg", 15650.53m, "Термопомпа Immergas Magis Pro 14 V2 T" },
                    { 4, 3, "Samsung ", 1, " Обем в литри: 260 л.\r\nВид Термопомпа: Сплит с вграден водосъдържател\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2493), "ClimateHub Mono\r\n– ​Интегрирано решение за отопление и битова гореща вода.\r\n– ​Компактен размер с голям бойлер за битова гореща вода (200 L и 260 L).\r\n– ​Интуитивен, сензорен контролер с цветен екран на няколко езика.\r\n– ​Проследяване на консумираната енергия чрез сензорен контролер.\r\n– ​Безпроблемно обслужване през сервизен прозорец в предната част.\r\n– ​Готовност за включване към фотоволтаици и Smart Grid.\r\n– ​2-зоново управление, подходящо за подово и радиаторно отопление.\r\n– ​Клас на SCOP A+++.\r\n– ​SmartThings система, съвместима с Wi-Fi комплект, предлаган като опция.\r\n– ​За осигуряване на минимална температура на водата е включен резервен нагревател", "termopompa-4.jpg", 20800.50m, "Термопомпа Samsung ClimateHub Mono" },
                    { 5, 18, "Toshiba  ", 1, "Вид Термопомпа: Сплит\r\nТип инвертор: Инвертор\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nНиво на шум: 26 - 30dB\r\nWi-Fi: Да\r\nЦвят: Бял", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2505), "Иновативна гама термопомпи. Компактен, ефективен и тих хиромодул. А+++ енергиен клас отопление. Серия ESTIA R32. Опция за свързване с WiFi. Удобни дистанционни управления. Произход Полша.", "termopompa5.jpg", 9318.98m, "Термопомпа Toshiba Estia" },
                    { 6, 18, "Immergas ", 2, "Максимална термична мощност\r\n(за БГВ) - 34.9 kW\r\n(за отопление) - 32.7 kW\r\nМинимална термична мощност - 4.0 kW\r\nМаксимална топлинна мощност\r\n(за БГВ) - 34.2 kW\r\n(за отопление) - 32.0 kW\r\nМинимална топлинна мощност - 3.9 kW\r\nЕфективност при:\r\nноминална мощност 80/60°C  -  97.8 %\r\n30% натоварване 80/60°C  -  103.2 %\r\nноминална мощност 40/30°C  -  106.2 %\r\n30% натоварване 40/30°C  -  108.2 %\r\nДебит на газ при горелката (метан) макс./мин. - 3.69 / 0.43 m³/h", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2515), "Повече комфорт със стенния двуконтурен комбиниран кондензен котел VICTRIX. Газовите котли на Immergas отговарят на новите Европейски Директиви за използване на енергия, фокусирани върху кондензната технология. Произведени в Италия. Лесни за инсталация във всяко пространство. Ново поколение котли подходящи за нови и стари вече изградени отоплителни инсталации. Всички модели притежават модулационна циркулационна помпа с нисък разход, за достигане на висока енергийна ефективност. ", "gazov-kotel1.jpg", 3569.90m, "Газов котел Immergas VICTRIX 35 kW TT" },
                    { 7, 10, "Immergas", 2, "Термична мощност: Макс. (режим БГВ): 28.7 kW; Макс. (режим отопление): 24.5 kW; Мин.: 4.5 kW", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2526), "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.", "gazov-kotel2.jpg", 2468.00m, "Газов котел Immergas VICTRIX Tera 24 V2 Plus" },
                    { 8, 8, "Immergas", 2, "Термична мощност: Макс. (режим БГВ): 34.8 kW; Макс. (режим отопление): 30.5 kW; Мин.: 4.5 kW", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2536), "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.", "gazov-kotel3.jpg", 3228.00m, "Газов котел Immergas VICTRIX Tera 35 V2 Plus" },
                    { 9, 5, "Bosch", 2, "Енергиен клас	\r\nA++/A++\r\n\r\nГаранция	\r\nдо 24 месеца\r\n\r\nМаксимална ел. консумация	\r\n94 W\r\n\r\nМощност при 40/30°C-kW	\r\n4,1 - 25,4\r\n\r\nМощност при 50/30°C-kW	\r\n3,3 - 25,2\r\n\r\nМощност при 80/30°C-kW	\r\n3,7 - 24,1\r\n\r\nПроизводител	\r\nBosch", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2547), "Bosch Condens 2500W WBC 28-1 DCE 23 - двуконтурен газов кондензен котел с мощност 3,7-28KW. Работи на принципа на  т. нар. кондензна техника – използва  както топлината, която възниква като измерима температура при процес на горене, така и  топлината от кондензацията на водните пари в отработените газове. ", "gazov-kotel4.png", 2479.00m, "Газов котел Bosch Condens 2500W" },
                    { 10, 7, "Viessmann", 2, "Стенен кондензен газов котел Viessmann Vitodens 100-W от 19 до 35 kW, едноконтурен;\r\nКоефициент на ефективност до 98% (Hs)/109% (Hi);\r\nИнтегриран мембранен разширитвисокоефективна работа с пълноценно използване на топлината от конденза;\r\nВентилатор с регулиране на оборотите за тиха и енергоспестяваща работа;\r\nМодулираща цилидрична горелка MatriX;\r\nВисокоефективна помпа;\r\nУправление по константна или по външна температура;\r\nНов осветен LCD-Touch дисплей за лесно и комфортно обслужване;", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2580), "Газов котел Viessmann Vitodens 100-W B1HC301 отговаря напълно на изискванията за енергийна ефективност заложени в Програмата за кредитиране на енергийната ефективност в дома. Vitodens 100-W е високоефективен стенен газов кондензен котел на изключително атрактивна цена и с безкомпромисното качество.", "gazov-kotel5.jpg", 3369.00m, "Газов котел Viessmann Vitodens 100-W " },
                    { 11, 15, "Daikin", 4, "Мощност охлаждане: 2.5 kW; Мощност отопление: 2.8 kW; Енергиен клас: A++; Ниво на шум: 21 dB", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2592), "Енергийно ефективен стенен климатик с модерен дизайн и тиха работа. Подходящ за помещения до 25 кв.м.", "klimatik1.jpg", 1399.00m, "Стенен климатик Daikin FTXF25C/RXF25C" },
                    { 12, 10, "Mitsubishi Electric", 4, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.15 kW; Енергиен клас: A+; Ниво на шум: 22 dB", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2603), "Компактен и стилен стенен климатик с висока енергийна ефективност и тих режим на работа.", "klimatik2.jpeg", 1249.00m, "Стенен климатик Mitsubishi Electric MSZ-HR25VF/MUZ-HR25VF" },
                    { 13, 12, "Fujitsu", 4, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 20 dB", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2615), "Високоефективен стенен климатик с компактен дизайн и ниско ниво на шум. Идеален за малки помещения.", "klimatik3.webp", 1099.00m, "Стенен климатик Fujitsu ASYG09LMCE/AOYG09LMCE" },
                    { 14, 8, "Toshiba", 4, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 21 dB", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2625), "Елегантен стенен климатик с висока енергийна ефективност и пречистване на въздуха. Подходящ за средни помещения.", "klimatik4.png", 1299.00m, "Стенен климатик Toshiba RAS-B10J2KVG-E/RAS-10J2AVG-E" },
                    { 15, 20, "Gree", 4, "Мощност охлаждане: 2.6 kW; Мощност отопление: 2.9 kW; Енергиен клас: A+; Ниво на шум: 22 dB", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2636), "Надежден стенен климатик с инверторна технология и ниско ниво на шум. Идеален за спални и малки офиси.", "klimatik5.png", 999.00m, "Стенен климатик Gree GWH09AAB-K6DNA1A" },
                    { 16, 5, "MIA", 3, "Мощност: 15 kW; КПД: 91%; Вместимост на бункера: 20 кг; Консумация на пелети: 1.1 - 3.3 кг/ч; Тегло: 150 кг", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2646), "Автоматична камина на пелети с водна риза, оборудвана с електронна циркулационна помпа, разширителен съд и седмичен програматор.", "kamina1.jpg", 3430.00m, "Камина на пелети MIA IDRO" },
                    { 17, 8, "DI CALORE", 3, "Мощност: 18 kW; КПД: 92%; Вместимост на бункера: 25 кг; Консумация на пелети: 1.2 - 3.8 кг/ч; Тегло: 160 кг", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2656), "Камина на пелети с водна риза, произведена с италиански компоненти, осигуряваща висока ефективност и надеждност.", "kamina2.png", 2904.00m, "Камина на пелети DI CALORE" },
                    { 18, 10, "BURNIT", 3, "Мощност: 20 kW; КПД: 90%; Вместимост на бункера: 30 кг; Консумация на пелети: 1.5 - 4.5 кг/ч; Тегло: 170 кг", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2666), "Пелетна камина с водна риза, оборудвана с вградена циркулационна помпа, разширителен съд и интелигентно управление.", "kamina3.jpg", 3369.65m, "Камина на пелети BURNIT Advant B2" },
                    { 19, 7, "BURNIT", 3, "Мощност: 25 kW; КПД: 91%; Вместимост на бункера: 35 кг; Консумация на пелети: 1.8 - 5.0 кг/ч; Тегло: 180 кг", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2676), "Ефективна камина на пелети с водна риза, подходяща за отопление на средни и големи помещения.", "kamina4.png", 3369.65m, "Камина на пелети BURNIT Advant" },
                    { 20, 6, "BURNIT", 3, "Мощност: 22 kW; КПД: 92%; Вместимост на бункера: 28 кг; Консумация на пелети: 1.4 - 4.2 кг/ч; Тегло: 160 кг", new DateTime(2025, 4, 8, 8, 33, 28, 793, DateTimeKind.Local).AddTicks(2687), "Стилна камина на пелети с водна риза, осигуряваща ефективно отопление и лесно управление.", "kamina5.png", 3953.90m, "Камина на пелети BURNIT Calor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
