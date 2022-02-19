using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductOperation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "images/nike.jpg", "Nike", 5000m, 500m },
                    { 2, "images/puma.jpg", "Puma", 2000m, 400m },
                    { 3, "images/Adidas.jpg", "Adidas", 3000m, 500m },
                    { 4, "images/Clarks.jpg", "Clarks", 5000m, 600m },
                    { 5, "images/Seeandwear.jpg", "Seeandwear", 2000m, 400m },
                    { 6, "images/Woodland.jpg", "Woodland", 2000m, 500m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
