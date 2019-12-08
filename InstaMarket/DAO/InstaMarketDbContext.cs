using InstaMarket.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMarket.DAO
{
    public class InstaMarketDbContext : DbContext
    {
        public DbSet<Chat> Chats{get;set;}
        public DbSet<Chat_Status> Chat_Statuses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Good_Dimension> Good_Dimensions { get; set; }
        public DbSet<Good_Dimension_Publication> Good_Dimension_Publications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Status> Order_Statuses { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Publication_Image> Publication_Images { get; set; }
        public DbSet<Publication_Video> Publication_Videos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["InstaMarketDatabase"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good_Dimension>()
                .HasIndex(gd => new { gd.Good_Id, gd.Dimension_Id })
                .IsUnique();
                
            modelBuilder.Entity<Good_Dimension>()
                .HasKey(gd => gd.Good_Dimension_Id);
            modelBuilder.Entity<Good_Dimension>()
                .HasOne(gd => gd.Good)
                .WithMany(g => g.Good_Dimensions)
                .HasForeignKey(gd => gd.Good_Id);
            modelBuilder.Entity<Good_Dimension>()
                .HasOne(gd => gd.Dimension)
                .WithMany(d => d.Good_Dimensions)
                .HasForeignKey(gd => gd.Dimension_Id);
                
            modelBuilder.Entity<Receipt>()
                .HasKey(r => new { r.Order_Id, r.Good_Dimension_Id });
            modelBuilder.Entity<Receipt>()
                .HasOne(r => r.Good_Dimension)
                .WithMany(gd => gd.Receipts)
                .HasForeignKey(r => r.Good_Dimension_Id);
            modelBuilder.Entity<Receipt>()
                .HasOne(r => r.Order)
                .WithMany(o => o.Receipts)
                .HasForeignKey(r => r.Order_Id);

            modelBuilder.Entity<Good_Dimension_Publication>()
                .HasKey(gdp => new { gdp.Good_Dimension_Id, gdp.Publication_Id });
            modelBuilder.Entity<Good_Dimension_Publication>()
                .HasOne(gdp => gdp.Good_Dimension)
                .WithMany(gd => gd.Good_Dimension_Publications)
                .HasForeignKey(gdp => gdp.Good_Dimension_Id);
            modelBuilder.Entity<Good_Dimension_Publication>()
                .HasOne(gdp => gdp.Publication)
                .WithMany(p => p.Good_Dimension_Publications)
                .HasForeignKey(gdp => gdp.Publication_Id);

            // Cascade deleting

            modelBuilder.Entity<Publication>()
                .HasOne(p => p.Shop)
                .WithMany(s => s.Publications)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Publication_Image>()
                .HasOne(i => i.Publication)
                .WithMany(p => p.Publication_Images)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Publication_Video>()
                .HasOne(v => v.Publication)
                .WithMany(p => p.Publication_Videos)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Publication)
                .WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Good_Dimension>()
                .HasOne(gd => gd.Good)
                .WithMany(g => g.Good_Dimensions)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Good_Dimension>()
                .HasOne(gd => gd.Dimension)
                .WithMany(d => d.Good_Dimensions)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Good_Dimension_Publication>()
                .HasOne(gpd => gpd.Publication)
                .WithMany(p => p.Good_Dimension_Publications)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Good_Dimension_Publication>()
                .HasOne(gpd => gpd.Good_Dimension)
                .WithMany(p => p.Good_Dimension_Publications)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Receipt>()
                .HasOne(r => r.Order)
                .WithMany(o => o.Receipts)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}