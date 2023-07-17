using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Octa-core (1x2.7 GHz Cortex-A78 & 3x2.4 GHz Cortex-A78 & 4x1.8 GHz Cortex-A55)", "https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-ce3-5g.jpg", 600m, "Nord CE3" },
                    { 2, "The OnePlus Nord 3 is finally here! It's been over two years since Nord 2 hit the shelves and it seems the wait was worth it. The third Nord brings a flagship-grade Fluid AMOLED, the top-of-the-line Dimensity 9000 5G chip, and an improved primary camera with a high-end Sony IMX890 sensor.", "https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-3r.jpg", 450m, "Nord 3" },
                    { 3, "The Nord N30 5G is the latest entry in the Nord N line but is far from an unfamiliar device. The Nord N30 5G is actually the US device name for the OnePlus Nord CE 3 Lite - an identical device meant for Europe and Asia that we've already reviewed. Digging a bit deeper, it is not hard to spot the similarities between the Nord N30 5G and the Realme 10 Pro.", "https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-n30-5g.jpg", 299m, "Nord N30" },
                    { 4, "Mediatek MT6983 Dimensity 9000 (4 nm)", "https://fdn2.gsmarena.com/vv/bigpic/oneplus-ace-2v.jpg", 200m, "Ace 2V" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
