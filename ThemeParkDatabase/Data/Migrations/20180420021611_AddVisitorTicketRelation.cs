using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddVisitorTicketRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisitorId",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_VisitorId",
                table: "Tickets",
                column: "VisitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Visitors_VisitorId",
                table: "Tickets",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Visitors_VisitorId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_VisitorId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "VisitorId",
                table: "Tickets");
        }
    }
}
