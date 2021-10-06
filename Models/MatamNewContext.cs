using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mat3am.Models
{
    public partial class MatamNewContext : DbContext
    {
        public MatamNewContext()
        {
        }

        public MatamNewContext(DbContextOptions<MatamNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Catogrey> Catogreys { get; set; }
        public virtual DbSet<Catogryy> Catogryys { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Costomer> Costomers { get; set; }
        public virtual DbSet<Dlevary> Dlevaries { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImg> ProductImgs { get; set; }
        public virtual DbSet<ProductImgNew> ProductImgNews { get; set; }
        public virtual DbSet<ProductNew> ProductNews { get; set; }
        public virtual DbSet<SelesBill> SelesBills { get; set; }
        public virtual DbSet<SelesBillDetali> SelesBillDetalis { get; set; }
        public virtual DbSet<Servi> Servis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8BU2MDH\\SQLEXPRESS;Database=MatamNew;Trusted_Connection=True;User ID=sa;Password=sa123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AboutU>(entity =>
            {
                entity.ToTable("aboutUs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Facbook)
                    .HasMaxLength(50)
                    .HasColumnName("facbook");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.Instgram)
                    .HasMaxLength(50)
                    .HasColumnName("instgram");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(50)
                    .HasColumnName("linkedIn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(50)
                    .HasColumnName("twitter");
            });

            modelBuilder.Entity<Catogrey>(entity =>
            {
                entity.ToTable("Catogrey");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Catogryy>(entity =>
            {
                entity.ToTable("Catogryy");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");
            });

            modelBuilder.Entity<Costomer>(entity =>
            {
                entity.ToTable("costomer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Imges)
                    .HasMaxLength(50)
                    .HasColumnName("imges");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Dlevary>(entity =>
            {
                entity.ToTable("Dlevary");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Catogry)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatogryId)
                    .HasConstraintName("FK_Product_Catogryy");
            });

            modelBuilder.Entity<ProductImg>(entity =>
            {
                entity.ToTable("ProductImg");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImgs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductImg_Product");
            });

            modelBuilder.Entity<ProductImgNew>(entity =>
            {
                entity.ToTable("ProductImgNew");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.ProductNew)
                    .WithMany(p => p.ProductImgNews)
                    .HasForeignKey(d => d.ProductNewId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductImgNew_ProductNew1");
            });

            modelBuilder.Entity<ProductNew>(entity =>
            {
                entity.ToTable("ProductNew");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Catogry)
                    .WithMany(p => p.ProductNews)
                    .HasForeignKey(d => d.CatogryId)
                    .HasConstraintName("FK_ProductNew_Catogrey");
            });

            modelBuilder.Entity<SelesBill>(entity =>
            {
                entity.ToTable("SelesBill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cash)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cash");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Totale).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Delvarys)
                    .WithMany(p => p.SelesBills)
                    .HasForeignKey(d => d.DelvaryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SelesBill_Dlevary");
            });

            modelBuilder.Entity<SelesBillDetali>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Totale).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SelesBillDetalis)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SelesBillDetalis_ProductNew");

                entity.HasOne(d => d.SelesBill)
                    .WithMany(p => p.SelesBillDetalis)
                    .HasForeignKey(d => d.SelesBillId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SelesBillDetalis_SelesBill1");
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClssesCss).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
