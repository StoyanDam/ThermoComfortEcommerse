using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Availability", "Brand", "CategoryId", "Characteristics", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Price", "ProductName" },
                values: new object[] { 1, 5, "Mitsubishi", 1, " Вид Термопомпа: Сплит\r\nЗахранване: 220V\r\nХладилен Агент: R410a\r\nМощност kW: 10 - 12 kW\r\nРаботен режим: Само Отопление\r\nРаботна температура: Нискотемпературна до 65°C", new DateTime(2025, 1, 30, 18, 15, 39, 660, DateTimeKind.Local).AddTicks(2601), "Термопомпената система се състои от следните компоненти:\r\n\r\nвъншно тяло\r\nвътрешно тяло Hydrobox\r\nмодул за управление.", "https://daricclima.bg/ufiles/articles/1/2024/10/termopompa-mitsubishi-electric-power-inverter-puhz-sw120vha-ehst20c-vm2d-2_9266.jpg?c=2&imbypass=on", false, 23209m, "Термопомпа Mitsubishi Electric Power Inverter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);
        }
    }
}
