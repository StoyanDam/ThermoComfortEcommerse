using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeletedReviewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6392), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6405), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6415), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6425), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6435), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6445), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6455), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6465), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6475), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6503), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6513), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6523), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6532), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6542), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6552), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6561), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6571), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6581), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6590), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2025, 3, 14, 9, 38, 31, 761, DateTimeKind.Local).AddTicks(6601), false });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }
    }
}
