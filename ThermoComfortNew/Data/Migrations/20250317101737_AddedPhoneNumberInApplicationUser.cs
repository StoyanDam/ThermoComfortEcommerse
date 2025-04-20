using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhoneNumberInApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 17, 30, 951, DateTimeKind.Local).AddTicks(4944));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 16, 22, 29, 16, 84, DateTimeKind.Local).AddTicks(1631));
        }
    }
}
