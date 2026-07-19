using Microsoft.EntityFrameworkCore;
using PPECheckoutSystem.Models;

namespace PPECheckoutSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<EquipmentCategory> EquipmentCategories => Set<EquipmentCategory>();
    public DbSet<EquipmentItem> EquipmentItems => Set<EquipmentItem>();
    public DbSet<CheckoutRecord> CheckoutRecords => Set<CheckoutRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.EmployeeNumber)
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.BadgeNumber)
            .IsUnique();

        modelBuilder.Entity<EquipmentCategory>()
            .HasIndex(c => c.CategoryName)
            .IsUnique();

        modelBuilder.Entity<EquipmentItem>()
            .HasIndex(e => e.ItemCode)
            .IsUnique();

        modelBuilder.Entity<EquipmentCategory>()
            .HasData(
                new EquipmentCategory
                {
                    EquipmentCategoryId = 1,
                    CategoryName = "Hard Hat",
                    Description = "Protective head equipment",
                    DefaultCheckoutDays = 7
                },
                new EquipmentCategory
                {
                    EquipmentCategoryId = 2,
                    CategoryName = "Safety Vest",
                    Description = "High-visibility safety vest",
                    DefaultCheckoutDays = 7
                },
                new EquipmentCategory
                {
                    EquipmentCategoryId = 3,
                    CategoryName = "Communication Device",
                    Description = "Radios and other communication tools",
                    DefaultCheckoutDays = 3
                }
            );
    }
}