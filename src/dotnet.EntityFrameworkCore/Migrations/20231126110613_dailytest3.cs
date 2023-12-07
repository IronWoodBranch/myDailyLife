using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    public partial class dailytest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "remark",
                table: "singlePayment",
                type: "nvarchar(max)",
                nullable: false,
                comment: "开支内容",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "消费内容");

            migrationBuilder.AddColumn<DateTime>(
                name: "theTime",
                table: "singlePayment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "开支时间");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "theTime",
                table: "singlePayment");

            migrationBuilder.AlterColumn<string>(
                name: "remark",
                table: "singlePayment",
                type: "nvarchar(max)",
                nullable: false,
                comment: "消费内容",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "开支内容");
        }
    }
}
