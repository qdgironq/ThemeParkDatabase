using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddAttractionLocationRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Attractions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_LocationId",
                table: "Attractions",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_Locations_LocationId",
                table: "Attractions",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_Locations_LocationId",
                table: "Attractions");

            migrationBuilder.DropIndex(
                name: "IX_Attractions_LocationId",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Attractions");
        }
    }
}
