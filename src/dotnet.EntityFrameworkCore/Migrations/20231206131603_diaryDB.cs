using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class diaryDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyDiary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diary = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "日记正文"),
                    diaryTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyDiary", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyDiary");
        }
    }
}
