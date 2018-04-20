using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThemeParkDatabase.Data.Migrations
{
    public partial class AddVendorVendorSalesReportRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "VendorSalesReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VendorSalesReports_VendorId",
                table: "VendorSalesReports",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendorSalesReports_Vendors_VendorId",
                table: "VendorSalesReports",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendorSalesReports_Vendors_VendorId",
                table: "VendorSalesReports");

            migrationBuilder.DropIndex(
                name: "IX_VendorSalesReports_VendorId",
                table: "VendorSalesReports");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "VendorSalesReports");
        }
    }
}
