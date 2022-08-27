using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManager.Migrations
{
    public partial class UpdateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Category",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
