﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ThemeParkDatabase.Data;

namespace ThemeParkDatabase.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180420034444_AddAttractionMaintencanceRequestRelation")]
    partial class AddAttractionMaintencanceRequestRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionTypeId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AttractionTypeId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.AttractionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AttractionTypes");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.AttractionVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionId");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("AttractionId");

                    b.ToTable("AttractionVisits");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.DailyParkReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumOfVisitors");

                    b.HasKey("Id");

                    b.ToTable("DailyParkReports");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.DeletionRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateRequested");

                    b.Property<int>("TableId");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("DeletionRequests");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<decimal>("Salary");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.MaintenanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttractionId");

                    b.Property<string>("CurrentStatus")
                        .IsRequired();

                    b.Property<DateTime>("DateRequested");

                    b.Property<DateTime?>("DateResolved");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<decimal>("EstimatedCost");

                    b.HasKey("Id");

                    b.HasIndex("AttractionId");

                    b.ToTable("MaintenanceRequests");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.ParkInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PostalCode");

                    b.Property<string>("State");

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.Property<string>("StreetNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ParkInformations");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateRedeemed");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<int>("TicketTypeId");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.TicketType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.VendorSalesReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("SalesGoal");

                    b.Property<decimal>("TotalSales");

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorSalesReports");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.VendorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("VendorTypes");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DailyParkReportId");

                    b.Property<DateTime>("Date");

                    b.Property<float>("InchesOfRain");

                    b.Property<bool>("Rainout");

                    b.Property<float>("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("DailyParkReportId")
                        .IsUnique();

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThemeParkDatabase.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Attraction", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.AttractionType", "AttractionType")
                        .WithMany()
                        .HasForeignKey("AttractionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.AttractionVisit", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Attraction", "Attraction")
                        .WithMany("AttractionVisits")
                        .HasForeignKey("AttractionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Department", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThemeParkDatabase.Data.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Employee", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.MaintenanceRequest", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Attraction", "Attraction")
                        .WithMany("MaintenanceRequests")
                        .HasForeignKey("AttractionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Ticket", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.TicketType", "TicketType")
                        .WithMany()
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThemeParkDatabase.Data.Visitor", "Visitor")
                        .WithMany("Tickets")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Vendor", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.VendorSalesReport", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.Vendor", "Vendor")
                        .WithMany("VendorSalesReports")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThemeParkDatabase.Data.Weather", b =>
                {
                    b.HasOne("ThemeParkDatabase.Data.DailyParkReport", "DailyParkReport")
                        .WithOne("WeatherReport")
                        .HasForeignKey("ThemeParkDatabase.Data.Weather", "DailyParkReportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
