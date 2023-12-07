using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class dailytest5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "calories",
                table: "singlePayment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "此顿饭热量是多少");

            migrationBuilder.AddColumn<bool>(
                name: "isMeal",
                table: "singlePayment",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "这顿是否是饭");

            migrationBuilder.CreateTable(
                name: "CaloriesOfFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "食物名"),
                    Calories = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "每100克多少热量")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaloriesOfFood", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaloriesOfFood");

            migrationBuilder.DropColumn(
                name: "calories",
                table: "singlePayment");

            migrationBuilder.DropColumn(
                name: "isMeal",
                table: "singlePayment");
        }
    }
}
