using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddVendorLocationRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Vendors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_LocationId",
                table: "Vendors",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Locations_LocationId",
                table: "Vendors",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Locations_LocationId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_LocationId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Vendors");
        }
    }
}
