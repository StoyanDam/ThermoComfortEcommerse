using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewPhotoGKOtel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4605), "gazov-kotel4.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 23, 17, 11, 239, DateTimeKind.Local).AddTicks(4669));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(564), "gazov-kotel4.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 2, 19, 18, 10, 15, 462, DateTimeKind.Local).AddTicks(610));
        }
    }
}
