using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddAttractionMaintencanceRequestRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttractionId",
                table: "MaintenanceRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRequests_AttractionId",
                table: "MaintenanceRequests",
                column: "AttractionId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRequests_Attractions_AttractionId",
                table: "MaintenanceRequests",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRequests_Attractions_AttractionId",
                table: "MaintenanceRequests");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceRequests_AttractionId",
                table: "MaintenanceRequests");

            migrationBuilder.DropColumn(
                name: "AttractionId",
                table: "MaintenanceRequests");
        }
    }
}
