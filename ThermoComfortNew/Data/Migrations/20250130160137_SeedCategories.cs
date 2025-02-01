using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThermoComfortNew.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Термопомпи", "Термопомпата е устройство, което използва енергия от външната среда (въздух, вода или земя), за да отоплява или охлажда сгради. " },
                    { 2, "Газови котли", "Газовите котли са отоплителни уреди, които използват природен газ или пропан-бутан за затопляне на вода, която циркулира в радиатори, подово отопление или битова гореща вода (БГВ)" },
                    { 3, "Пелетни камини", "Пелетните камини са отоплителни уреди, които използват дървесни пелети като гориво. Те работят автоматично, като подават пелетите в горивната камера чрез шнек и регулират горенето с вентилатор и електроника." },
                    { 4, "Климатици", "Климатикът е уред, който охлажда, отоплява и регулира влажността на въздуха в затворени помещения. Работи чрез топлообменен процес, при който прехвърля топлина от едно място на друго с помощта на хладилен агент (фреон)." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);
        }
    }
}
