using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddAttractionAttractionTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttractionTypeId",
                table: "Attractions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_AttractionTypeId",
                table: "Attractions",
                column: "AttractionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attractions_AttractionTypes_AttractionTypeId",
                table: "Attractions",
                column: "AttractionTypeId",
                principalTable: "AttractionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attractions_AttractionTypes_AttractionTypeId",
                table: "Attractions");

            migrationBuilder.DropIndex(
                name: "IX_Attractions_AttractionTypeId",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "AttractionTypeId",
                table: "Attractions");
        }
    }
}
