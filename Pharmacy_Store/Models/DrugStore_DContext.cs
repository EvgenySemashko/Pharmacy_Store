using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pharmacy_Store.Models
{
    public partial class DrugStore_DContext : DbContext
    {
        public DrugStore_DContext()
        {
        }

        public DrugStore_DContext(DbContextOptions<DrugStore_DContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdressesPharmacy> AdressesPharmacies { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPharmacy> ProductPharmacies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M139CL2;Initial Catalog=DrugStore_D;Integrated Security=True;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<AdressesPharmacy>(entity =>
            {
                entity.HasKey(e => e.IdAdressPharmacy);

                entity.Property(e => e.IdAdressPharmacy)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_AdressPharmacy");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumberBuilding)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Number_Building");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.HasKey(e => e.IdPharmacy);

                entity.Property(e => e.IdPharmacy)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Pharmacy");

                entity.Property(e => e.NamePharmacy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Pharmacy");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK_Product");

                entity.Property(e => e.IdProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Product");

                entity.Property(e => e.CountProduct).HasColumnName("Count_Product");

                entity.Property(e => e.NameProduct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Product");

                entity.Property(e => e.PriceProduct)
                    .HasColumnType("money")
                    .HasColumnName("Price_Product");
            });

            modelBuilder.Entity<ProductPharmacy>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdPharmacy });

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.IdPharmacy).HasColumnName("Id_Pharmacy");

                entity.HasOne(d => d.IdPharmacyNavigation)
                    .WithMany(p => p.ProductPharmacies)
                    .HasForeignKey(d => d.IdPharmacy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPharmacies_Pharmacies");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.ProductPharmacies)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPharmacies_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
