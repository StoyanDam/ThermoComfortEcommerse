using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4393), 23209.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Availability", "Brand", "CategoryId", "Characteristics", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Price", "ProductName" },
                values: new object[,]
                {
                    { 2, 8, "Daikin ", 1, " Обем в литри: 230 л.\r\nВид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4398), "Нискотемпературна термопомпа + 230 литров бойлер\r\n› Комбиниран вътрешен модул с вграден неръждаем бойлер 180 или 230 литра и термопомпа за лесен монтаж\r\n› Всички хидравлични компоненти са включени - не са необходими външни компоненти\r\n› Електрическите и хидравлични компоненти са в предната част за лесен достъп\r\n› Компактни размери - отпечатък 595х625 mm\r\n› Вграден помощен нагревател 6 или 9 kW\r\n› Работа в термопомпен режим до -25°C​\r\n› Съвместима с Onecta и гласов контрол​", "https://daricclima.bg/ufiles/articles/1/2022/05/termopompa-daikin-altherma-3r-stenno-tiqlo-ehvh08s23e6v-erga06ev-otoplenie-6-kw_2090.jpg", false, 15210.12m, "Термопомпа Daikin Altherma 3" },
                    { 3, 15, "Immergas ", 1, " Вид Термопомпа: Сплит\r\nЗахранване: 380V\r\nХладилен Агент: R410a\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nЕнергиен клас охлаждане: A+", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4403), "ИДЕАЛНА ЗАЩИТА ОТ ЗАМРЪЗВАНЕ Хидравличният модул е напълно защитен от замръзване, поради разположението му вътре в жилището;\r\nКОМПАКТНО РЕШЕНИЕ Обединява в отделния хидравличен модул основните компоненти на хидравличната инсталация, а именно: комплект нагреватели за инсталацията (опция), разширителен съд, 3-пътен превключващ вентил за БГВ, хидравлична група с циркулационна помпа и комплект нагреватели за системата (опция) - до 2 - за версии 12, 14 и 16.\r\nЗАПАЗВАНЕ НА ЕСТЕТИКАТА Външното тяло е по-компактно, което осигурява по-голяма гъвкавост при инсталация на фасадите извън сградата или на тераса.\r\nЛЕСЕН МОНТАЖ Професионалистът може да използва MAGIS PRO V2 като автономно решение за отопление, охлаждане и битова гореща вода или като решениe за интегриране в инсталационни табла и инсталационни табла за вграждане в стена.", "https://daricclima.bg/ufiles/articles/1/2023/11/termopompa-immergas-model-magis-pro-14-v2t_9340.jpg", false, 15650.53m, "Термопомпа Immergas Magis Pro 14 V2 T" },
                    { 4, 3, "Samsung ", 1, " Обем в литри: 260 л.\r\nВид Термопомпа: Сплит с вграден водосъдържател\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 13 - 16 kW\r\nРаботен режим: Отопление и охлаждане\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4407), "ClimateHub Mono\r\n– ​Интегрирано решение за отопление и битова гореща вода.\r\n– ​Компактен размер с голям бойлер за битова гореща вода (200 L и 260 L).\r\n– ​Интуитивен, сензорен контролер с цветен екран на няколко езика.\r\n– ​Проследяване на консумираната енергия чрез сензорен контролер.\r\n– ​Безпроблемно обслужване през сервизен прозорец в предната част.\r\n– ​Готовност за включване към фотоволтаици и Smart Grid.\r\n– ​2-зоново управление, подходящо за подово и радиаторно отопление.\r\n– ​Клас на SCOP A+++.\r\n– ​SmartThings система, съвместима с Wi-Fi комплект, предлаган като опция.\r\n– ​За осигуряване на минимална температура на водата е включен резервен нагревател", "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-samsung-climatehub-mono-ae160rxydgg-eu-ae260rnwmgg-eu-trifazna_9653.jpg", false, 20800.50m, "Термопомпа Samsung ClimateHub Mono" },
                    { 5, 18, "Toshiba  ", 1, "Вид Термопомпа: Сплит\r\nТип инвертор: Инвертор\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nНиво на шум: 26 - 30dB\r\nWi-Fi: Да\r\nЦвят: Бял", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4413), "Иновативна гама термопомпи. Компактен, ефективен и тих хиромодул. А+++ енергиен клас отопление. Серия ESTIA R32. Опция за свързване с WiFi. Удобни дистанционни управления. Произход Полша.", "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-toshiba-estia-hwt-601xwht6w-e-hwt-601hw-e-trifazna_4650.jpg", false, 9318.98m, "Термопомпа Toshiba Estia" },
                    { 6, 18, "Toshiba  ", 2, "Вид Термопомпа: Сплит\r\nТип инвертор: Инвертор\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nНиво на шум: 26 - 30dB\r\nWi-Fi: Да\r\nЦвят: Бял", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4417), "Иновативна гама термопомпи. Компактен, ефективен и тих хиромодул. А+++ енергиен клас отопление. Серия ESTIA R32. Опция за свързване с WiFi. Удобни дистанционни управления. Произход Полша.", "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-toshiba-estia-hwt-601xwht6w-e-hwt-601hw-e-trifazna_4650.jpg", false, 9318.98m, "Газов котел Immergas VICTRIX 35 kW TT" },
                    { 7, 10, "Immergas", 2, "Термична мощност: Макс. (режим БГВ): 28.7 kW; Макс. (режим отопление): 24.5 kW; Мин.: 4.5 kW", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4421), "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-tera-24-plus_4651.jpg", false, 2468.00m, "Газов котел Immergas VICTRIX Tera 24 V2 Plus" },
                    { 8, 8, "Immergas", 2, "Термична мощност: Макс. (режим БГВ): 34.8 kW; Макс. (режим отопление): 30.5 kW; Мин.: 4.5 kW", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4425), "Стенен кондензационен котел за отопление и производство на БГВ с външен обемен бойлер. Нов дизайн, ефективност и технология Hydrogen Ready.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-tera-35-plus_4652.jpg", false, 3228.00m, "Газов котел Immergas VICTRIX Tera 35 V2 Plus" },
                    { 9, 5, "Immergas", 2, "Максимална термична мощност: (за БГВ) - 29.1 kW; (за отопление) - 24.9 kW; Минимална термична мощност - 2.9 kW", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4430), "Стенен комбиниран кондензен котел за отопление и проточно производство на битова гореща вода. Подходящ за нови и стари отоплителни инсталации.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-kw-28-tt_4653.jpg", false, 3286.00m, "Газов котел Immergas VICTRIX 28 kW TT" },
                    { 10, 7, "Immergas", 2, "Термична мощност: Макс. (режим БГВ): 28.9 kW; Макс. (режим отопление): 24.7 kW; Мин.: 4.5 kW", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4443), "Стенен кондензен комбиниран котел с вграден обемен бойлер 45 литра за БГВ и отопление. Модел с висока енергийна икономичност и иновативен дизайн.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-zeus-25_4654.jpg", false, 4784.00m, "Газов котел Immergas VICTRIX Zeus 25" },
                    { 11, 15, "Daikin", 3, "Мощност охлаждане: 2.5 kW; Мощност отопление: 2.8 kW; Енергиен клас: A++; Ниво на шум: 21 dB", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4447), "Енергийно ефективен стенен климатик с модерен дизайн и тиха работа. Подходящ за помещения до 25 кв.м.", "https://daricclima.bg/ufiles/articles/1/2024/05/daikin-ftxf25c-rxf25c_4650.jpg", false, 1399.00m, "Стенен климатик Daikin FTXF25C/RXF25C" },
                    { 12, 10, "Mitsubishi Electric", 3, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.15 kW; Енергиен клас: A+; Ниво на шум: 22 dB", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4452), "Компактен и стилен стенен климатик с висока енергийна ефективност и тих режим на работа.", "https://daricclima.bg/ufiles/articles/1/2024/05/mitsubishi-electric-msz-hr25vf-muz-hr25vf_4651.jpg", false, 1249.00m, "Стенен климатик Mitsubishi Electric MSZ-HR25VF/MUZ-HR25VF" },
                    { 13, 12, "Fujitsu", 3, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 20 dB", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4456), "Високоефективен стенен климатик с компактен дизайн и ниско ниво на шум. Идеален за малки помещения.", "https://daricclima.bg/ufiles/articles/1/2024/05/fujitsu-asyg09lmce-aoyg09lmce_4652.jpg", false, 1099.00m, "Стенен климатик Fujitsu ASYG09LMCE/AOYG09LMCE" },
                    { 14, 8, "Toshiba", 3, "Мощност охлаждане: 2.5 kW; Мощност отопление: 3.2 kW; Енергиен клас: A++; Ниво на шум: 21 dB", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4460), "Елегантен стенен климатик с висока енергийна ефективност и пречистване на въздуха. Подходящ за средни помещения.", "https://daricclima.bg/ufiles/articles/1/2024/05/toshiba-ras-b10j2kvg-e-ras-10j2avg-e_4653.jpg", false, 1299.00m, "Стенен климатик Toshiba RAS-B10J2KVG-E/RAS-10J2AVG-E" },
                    { 15, 20, "Gree", 3, "Мощност охлаждане: 2.6 kW; Мощност отопление: 2.9 kW; Енергиен клас: A+; Ниво на шум: 22 dB", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4465), "Надежден стенен климатик с инверторна технология и ниско ниво на шум. Идеален за спални и малки офиси.", "https://daricclima.bg/ufiles/articles/1/2024/05/gree-gwh09aab-k6dna1a_4654.jpg", false, 999.00m, "Стенен климатик Gree GWH09AAB-K6DNA1A" },
                    { 16, 5, "MIA", 4, "Мощност: 15 kW; КПД: 91%; Вместимост на бункера: 20 кг; Консумация на пелети: 1.1 - 3.3 кг/ч; Тегло: 150 кг", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4469), "Автоматична камина на пелети с водна риза, оборудвана с електронна циркулационна помпа, разширителен съд и седмичен програматор.", "https://bulgarterm.bg/wp-content/uploads/2020/01/MIA-IDRO.jpg", false, 3430.00m, "Камина на пелети MIA IDRO" },
                    { 17, 8, "DI CALORE", 4, "Мощност: 18 kW; КПД: 92%; Вместимост на бункера: 25 кг; Консумация на пелети: 1.2 - 3.8 кг/ч; Тегло: 160 кг", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4473), "Камина на пелети с водна риза, произведена с италиански компоненти, осигуряваща висока ефективност и надеждност.", "https://bulgarterm.bg/wp-content/uploads/2020/01/DI-CALORE.jpg", false, 2904.00m, "Камина на пелети DI CALORE" },
                    { 18, 10, "BURNIT", 4, "Мощност: 20 kW; КПД: 90%; Вместимост на бункера: 30 кг; Консумация на пелети: 1.5 - 4.5 кг/ч; Тегло: 170 кг", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4478), "Пелетна камина с водна риза, оборудвана с вградена циркулационна помпа, разширителен съд и интелигентно управление.", "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Advant-B2.jpg", false, 3369.65m, "Камина на пелети BURNIT Advant B2" },
                    { 19, 7, "BURNIT", 4, "Мощност: 25 kW; КПД: 91%; Вместимост на бункера: 35 кг; Консумация на пелети: 1.8 - 5.0 кг/ч; Тегло: 180 кг", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4523), "Ефективна камина на пелети с водна риза, подходяща за отопление на средни и големи помещения.", "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Advant.jpg", false, 3369.65m, "Камина на пелети BURNIT Advant" },
                    { 20, 6, "BURNIT", 4, "Мощност: 22 kW; КПД: 92%; Вместимост на бункера: 28 кг; Консумация на пелети: 1.4 - 4.2 кг/ч; Тегло: 160 кг", new DateTime(2025, 2, 1, 19, 37, 55, 375, DateTimeKind.Local).AddTicks(4527), "Стилна камина на пелети с водна риза, осигуряваща ефективно отопление и лесно управление.", "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Calor.jpg", false, 3953.90m, "Камина на пелети BURNIT Calor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2025, 1, 30, 18, 15, 39, 660, DateTimeKind.Local).AddTicks(2601), 23209m });
        }
    }
}
