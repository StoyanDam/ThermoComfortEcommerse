using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductPhotosDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(810), "termopompa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(829), "termopompa2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(842), "termopompa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(878), "termopompa-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(902), "termopompa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price" },
                values: new object[] { "Immergas ", "Максимална термична мощност\r\n(за БГВ) - 34.9 kW\r\n(за отопление) - 32.7 kW\r\nМинимална термична мощност - 4.0 kW\r\nМаксимална топлинна мощност\r\n(за БГВ) - 34.2 kW\r\n(за отопление) - 32.0 kW\r\nМинимална топлинна мощност - 3.9 kW\r\nЕфективност при:\r\nноминална мощност 80/60°C  -  97.8 %\r\n30% натоварване 80/60°C  -  103.2 %\r\nноминална мощност 40/30°C  -  106.2 %\r\n30% натоварване 40/30°C  -  108.2 %\r\nДебит на газ при горелката (метан) макс./мин. - 3.69 / 0.43 m³/h", new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(922), "Повече комфорт със стенния двуконтурен комбиниран кондензен котел VICTRIX. Газовите котли на Immergas отговарят на новите Европейски Директиви за използване на енергия, фокусирани върху кондензната технология. Произведени в Италия. Лесни за инсталация във всяко пространство. Ново поколение котли подходящи за нови и стари вече изградени отоплителни инсталации. Всички модели притежават модулационна циркулационна помпа с нисък разход, за достигане на висока енергийна ефективност. ", "gazov-kotel1.jpg", 3569.90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(937), "gazov-kotel2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(986), "gazov-kotel3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { "Bosch", "Енергиен клас	\r\nA++/A++\r\n\r\nГаранция	\r\nдо 24 месеца\r\n\r\nМаксимална ел. консумация	\r\n94 W\r\n\r\nМощност при 40/30°C-kW	\r\n4,1 - 25,4\r\n\r\nМощност при 50/30°C-kW	\r\n3,3 - 25,2\r\n\r\nМощност при 80/30°C-kW	\r\n3,7 - 24,1\r\n\r\nПроизводител	\r\nBosch", new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1000), "Bosch Condens 2500W WBC 28-1 DCE 23 - двуконтурен газов кондензен котел с мощност 3,7-28KW. Работи на принципа на  т. нар. кондензна техника – използва  както топлината, която възниква като измерима температура при процес на горене, така и  топлината от кондензацията на водните пари в отработените газове. ", "gazov-kotel4.jpg", 2479.00m, "Газов котел Bosch Condens 2500W" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { "Viessmann", "Стенен кондензен газов котел Viessmann Vitodens 100-W от 19 до 35 kW, едноконтурен;\r\nКоефициент на ефективност до 98% (Hs)/109% (Hi);\r\nИнтегриран мембранен разширитвисокоефективна работа с пълноценно използване на топлината от конденза;\r\nВентилатор с регулиране на оборотите за тиха и енергоспестяваща работа;\r\nМодулираща цилидрична горелка MatriX;\r\nВисокоефективна помпа;\r\nУправление по константна или по външна температура;\r\nНов осветен LCD-Touch дисплей за лесно и комфортно обслужване;", new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1013), "Газов котел Viessmann Vitodens 100-W B1HC301 отговаря напълно на изискванията за енергийна ефективност заложени в Програмата за кредитиране на енергийната ефективност в дома. Vitodens 100-W е високоефективен стенен газов кондензен котел на изключително атрактивна цена и с безкомпромисното качество.", "gazov-kotel5.jpg", 3369.00m, "Газов котел Viessmann Vitodens 100-W " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1027), "klimatik1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1041), "klimatik2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1056), "klimatik3.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1076), "klimatik4.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1095), "klimatik5.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1157), "kamina1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1170), "kamina2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1184), "kamina3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1197), "kamina4.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 12, 7, 41, 9, 320, DateTimeKind.Local).AddTicks(1210), "kamina5.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4674), "https://daricclima.bg/ufiles/articles/1/2024/10/termopompa-mitsubishi-electric-power-inverter-puhz-sw120vha-ehst20c-vm2d-2_9266.jpg?c=2&imbypass=on" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4682), "https://daricclima.bg/ufiles/articles/1/2022/05/termopompa-daikin-altherma-3r-stenno-tiqlo-ehvh08s23e6v-erga06ev-otoplenie-6-kw_2090.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4686), "https://daricclima.bg/ufiles/articles/1/2023/11/termopompa-immergas-model-magis-pro-14-v2t_9340.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4690), "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-samsung-climatehub-mono-ae160rxydgg-eu-ae260rnwmgg-eu-trifazna_9653.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4730), "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-toshiba-estia-hwt-601xwht6w-e-hwt-601hw-e-trifazna_4650.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price" },
                values: new object[] { "Toshiba  ", "Вид Термопомпа: Сплит\r\nТип инвертор: Инвертор\r\nЗахранване: 380V\r\nХладилен Агент: R32\r\nМощност kW: 4 - 9 kW\r\nРаботен режим: Отопление и охлаждане\r\nЕнергиен клас отопление: A+++\r\nНиво на шум: 26 - 30dB\r\nWi-Fi: Да\r\nЦвят: Бял", new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4735), "Иновативна гама термопомпи. Компактен, ефективен и тих хиромодул. А+++ енергиен клас отопление. Серия ESTIA R32. Опция за свързване с WiFi. Удобни дистанционни управления. Произход Полша.", "https://daricclima.bg/ufiles/articles/1/2024/05/termopompa-toshiba-estia-hwt-601xwht6w-e-hwt-601hw-e-trifazna_4650.jpg", 9318.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4739), "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-tera-24-plus_4651.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4743), "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-tera-35-plus_4652.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { "Immergas", "Максимална термична мощност: (за БГВ) - 29.1 kW; (за отопление) - 24.9 kW; Минимална термична мощност - 2.9 kW", new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4747), "Стенен комбиниран кондензен котел за отопление и проточно производство на битова гореща вода. Подходящ за нови и стари отоплителни инсталации.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-kw-28-tt_4653.jpg", 3286.00m, "Газов котел Immergas VICTRIX 28 kW TT" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Brand", "Characteristics", "CreatedOn", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { "Immergas", "Термична мощност: Макс. (режим БГВ): 28.9 kW; Макс. (режим отопление): 24.7 kW; Мин.: 4.5 kW", new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4751), "Стенен кондензен комбиниран котел с вграден обемен бойлер 45 литра за БГВ и отопление. Модел с висока енергийна икономичност и иновативен дизайн.", "https://daricclima.bg/ufiles/articles/1/2024/05/gazov-kotel-immergas-victrix-zeus-25_4654.jpg", 4784.00m, "Газов котел Immergas VICTRIX Zeus 25" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4755), "https://daricclima.bg/ufiles/articles/1/2024/05/daikin-ftxf25c-rxf25c_4650.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4760), "https://daricclima.bg/ufiles/articles/1/2024/05/mitsubishi-electric-msz-hr25vf-muz-hr25vf_4651.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4764), "https://daricclima.bg/ufiles/articles/1/2024/05/fujitsu-asyg09lmce-aoyg09lmce_4652.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4768), "https://daricclima.bg/ufiles/articles/1/2024/05/toshiba-ras-b10j2kvg-e-ras-10j2avg-e_4653.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4772), "https://daricclima.bg/ufiles/articles/1/2024/05/gree-gwh09aab-k6dna1a_4654.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4776), "https://bulgarterm.bg/wp-content/uploads/2020/01/MIA-IDRO.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4780), "https://bulgarterm.bg/wp-content/uploads/2020/01/DI-CALORE.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4784), "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Advant-B2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4788), "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Advant.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 1, 20, 13, 45, 388, DateTimeKind.Local).AddTicks(4792), "https://bulgarterm.bg/wp-content/uploads/2020/01/BURNIT-Calor.jpg" });
        }
    }
}
