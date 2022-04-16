using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demoexam
{
    public partial class demoexamContext : DbContext
    {
        public demoexamContext()
        {
        }

        public demoexamContext(DbContextOptions<demoexamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Nameproduct> Nameproducts { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHAZA\\SQLEXPRESS;Database=demoexam;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CategoryValue)
                    .HasMaxLength(100)
                    .HasColumnName("categoryValue");
            });

            modelBuilder.Entity<Nameproduct>(entity =>
            {
                entity.HasKey(e => e.NameId);

                entity.ToTable("nameproduct");

                entity.Property(e => e.NameId).HasColumnName("nameID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Productarticle);

                entity.ToTable("product");

                entity.Property(e => e.Productarticle)
                    .HasMaxLength(100)
                    .HasColumnName("productarticle");

                entity.Property(e => e.ProductImage)
                    .HasColumnType("image")
                    .HasColumnName("productImage");

                entity.Property(e => e.Productcategory).HasColumnName("productcategory");

                entity.Property(e => e.Productcurrentdiscount)
                    .HasMaxLength(100)
                    .HasColumnName("productcurrentdiscount");

                entity.Property(e => e.Productdescription).HasColumnName("productdescription");

                entity.Property(e => e.Productname)
                    .HasMaxLength(100)
                    .HasColumnName("productname");

                entity.Property(e => e.Productprice)
                    .HasColumnType("money")
                    .HasColumnName("productprice");

                entity.Property(e => e.Productprovider).HasColumnName("productprovider");

                entity.Property(e => e.Productquantityinstock).HasColumnName("productquantityinstock");

                entity.Property(e => e.Productsale)
                    .HasMaxLength(100)
                    .HasColumnName("productsale");

                entity.Property(e => e.Productstatus).HasColumnName("productstatus");

                entity.Property(e => e.Productsupplier)
                    .HasMaxLength(100)
                    .HasColumnName("productsupplier");

                entity.Property(e => e.Productunits).HasColumnName("productunits");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("provider");

                entity.Property(e => e.ProviderId).HasColumnName("providerID");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .HasColumnName("providerName");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId).HasColumnName("statusID");

                entity.Property(e => e.Status1)
                    .HasMaxLength(100)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.Property(e => e.Supplier1)
                    .HasMaxLength(100)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.UnitsId);

                entity.ToTable("units");

                entity.Property(e => e.UnitsId).HasColumnName("unitsID");

                entity.Property(e => e.Units)
                    .HasMaxLength(100)
                    .HasColumnName("units");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserLogin).HasColumnName("userLogin");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPassword).HasColumnName("userPassword");

                entity.Property(e => e.UserPatronymic)
                    .HasMaxLength(100)
                    .HasColumnName("userPatronymic");

                entity.Property(e => e.UserRole).HasColumnName("userRole");

                entity.Property(e => e.UserSurname)
                    .HasMaxLength(100)
                    .HasColumnName("userSurname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
