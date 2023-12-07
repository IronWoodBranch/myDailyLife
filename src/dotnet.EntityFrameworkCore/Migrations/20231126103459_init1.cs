using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "singlePayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "支出")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singlePayment", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "singlePayment");
        }
    }
}
