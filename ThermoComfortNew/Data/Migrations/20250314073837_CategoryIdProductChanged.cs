using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoryIdProductChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6601) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2025, 3, 10, 12, 53, 56, 43, DateTimeKind.Local).AddTicks(6255) });
        }
    }
}
