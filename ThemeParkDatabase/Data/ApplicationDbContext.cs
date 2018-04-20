using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ThemeParkDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorSalesReport> VendorSalesReports { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ParkInformation> ParkInformations { get; set; }
        public DbSet<DeletionRequest> DeletionRequests { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<DailyParkReport> DailyParkReports { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AttractionType> AttractionTypes { get; set; }
        public DbSet<AttractionVisit> AttractionVisits { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department);

            builder.Entity<Department>()
                .HasOne(d => d.Manager);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
