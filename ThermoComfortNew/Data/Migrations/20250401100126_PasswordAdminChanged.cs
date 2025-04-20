using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class PasswordAdminChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 13, 1, 25, 243, DateTimeKind.Local).AddTicks(4524));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 17, 12, 46, 20, 379, DateTimeKind.Local).AddTicks(4479));
        }
    }
}
