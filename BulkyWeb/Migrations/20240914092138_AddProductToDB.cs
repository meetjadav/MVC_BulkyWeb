using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    ISBN = table.Column<string>(type: "longtext", nullable: false),
                    Author = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Suzanne Collins", "The Hunger Games is a dystopian novel by Suzanne Collins where teenagers are forced to participate in a deadly televised competition in a totalitarian society.", "9780545791878", 499.0, "The Hunger Games" },
                    { 2, "Frank Herbert", "Dune by Frank Herbert is a science fiction epic set on a desert planet, exploring themes of politics, religion,and ecological survival.", "9780425027066", 799.0, "Dune" },
                    { 3, "Dan Brown", "The Da Vinci Code by Dan Brown is a mystery-thriller that follows a symbologist as he uncovers a hidden religious secret through a series of historical and cryptic clues.", "9780385513227", 399.0, "The Da Vinci Code" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);
        }
    }
}
