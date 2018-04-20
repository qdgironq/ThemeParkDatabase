using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddAttractionAttractionVisitRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttractionId",
                table: "AttractionVisits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttractionVisits_AttractionId",
                table: "AttractionVisits",
                column: "AttractionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionVisits_Attractions_AttractionId",
                table: "AttractionVisits",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttractionVisits_Attractions_AttractionId",
                table: "AttractionVisits");

            migrationBuilder.DropIndex(
                name: "IX_AttractionVisits_AttractionId",
                table: "AttractionVisits");

            migrationBuilder.DropColumn(
                name: "AttractionId",
                table: "AttractionVisits");
        }
    }
}
