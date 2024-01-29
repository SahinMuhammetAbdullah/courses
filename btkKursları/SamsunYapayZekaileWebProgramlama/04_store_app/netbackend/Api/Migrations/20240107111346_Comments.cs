using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "/images/default.jpg"),
                    AtCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    AtCreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AtCreatedDate", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(7389), "/images/1.jpg", "Laptop", 1500m },
                    { 2, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(7401), "/images/2.jpg", "Smartphone", 800m },
                    { 3, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(7403), "/images/3.jpg", "Headphones", 100m },
                    { 4, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(7404), "/images/4.jpg", "Tablet", 600m },
                    { 5, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(7405), "/images/5.jpg", "Smartwatch", 300m }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(4320), 1, "Harika bir ürün." },
                    { 2, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(4337), 1, "Harika bir ürün, kesinlikle tavsiye ediyorum." },
                    { 3, new DateTime(2024, 1, 7, 14, 13, 45, 680, DateTimeKind.Local).AddTicks(4338), 1, "Kargo biraz gecikti ama beklediğime değdi. Teşekkürler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
