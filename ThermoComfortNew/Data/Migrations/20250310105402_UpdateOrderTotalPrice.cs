using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderTotalPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6255));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 5, 9, 48, 15, 903, DateTimeKind.Local).AddTicks(8129));
        }
    }
}
