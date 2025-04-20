using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCartCounter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 8, 37, 43, 877, DateTimeKind.Local).AddTicks(6489));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 15, 14, 3, 4, 50, DateTimeKind.Local).AddTicks(3515));
        }
    }
}
