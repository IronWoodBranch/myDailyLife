using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class daily_changeFoodColunmName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Food",
                table: "CaloriesOfFood",
                newName: "FoodName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "CaloriesOfFood",
                newName: "Food");
        }
    }
}
