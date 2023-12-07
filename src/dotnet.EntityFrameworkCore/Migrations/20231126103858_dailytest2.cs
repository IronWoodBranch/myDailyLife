using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class dailytest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "singlePayment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "消费内容");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "remark",
                table: "singlePayment");
        }
    }
}
