using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace taskk4.Models;

public partial class MyDbContextProduct : DbContext
{
    public MyDbContextProduct()
    {
    }

    public MyDbContextProduct(DbContextOptions<MyDbContextProduct> options)
        : base(options)
    {
    }

    public virtual DbSet<Productt> Productts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1HTCEEO;Database=STORE;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Productt__3214EC27188BB9FB");

            entity.ToTable("Productt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
