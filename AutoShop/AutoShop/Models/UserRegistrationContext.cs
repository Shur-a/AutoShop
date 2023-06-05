using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.Models{

public partial class UserRegistrationContext : DbContext
{
    public UserRegistrationContext()
    {
    }

    public UserRegistrationContext(DbContextOptions<UserRegistrationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Authorization> Authorizations { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-UU09PO0;Database= UserRegistration;TrustServerCertificate= true;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Authorization>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Authorization");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.NameId);

            entity.Property(e => e.ModelCar).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.YearofreleaseCar).HasMaxLength(50);

            entity.HasOne(d => d.Car).WithMany(p => p.Details)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Details_Cars");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
} }
