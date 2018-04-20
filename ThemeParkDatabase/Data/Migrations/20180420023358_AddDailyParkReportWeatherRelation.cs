using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddDailyParkReportWeatherRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DailyParkReportId",
                table: "Weathers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_DailyParkReportId",
                table: "Weathers",
                column: "DailyParkReportId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_DailyParkReports_DailyParkReportId",
                table: "Weathers",
                column: "DailyParkReportId",
                principalTable: "DailyParkReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_DailyParkReports_DailyParkReportId",
                table: "Weathers");

            migrationBuilder.DropIndex(
                name: "IX_Weathers_DailyParkReportId",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "DailyParkReportId",
                table: "Weathers");
        }
    }
}
