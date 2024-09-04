using Eticaret.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Eticaret.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }



        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Category ile SubCategory arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<SubCategory>()
                .HasOne(s => s.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(s => s.Category_Id)
                .OnDelete(DeleteBehavior.Restrict); // Cascade yerine Restrict

            // Product ile Category arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany() // Category'de Products koleksiyonu yok, sadece bu ilişkide kullanılır
                .HasForeignKey(p => p.Category_Id)
                .OnDelete(DeleteBehavior.Restrict); // Cascade yerine Restrict

            // Product ile SubCategory arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Product>()
                .HasOne(p => p.SubCategory)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SubCategory_Id)
                .OnDelete(DeleteBehavior.Restrict); // Cascade yerine Restrict
        }
        public DbSet<Eticaret.Models.Color> Color { get; set; } = default!;
        public DbSet<Eticaret.Models.Size> Size { get; set; } = default!;




    }
}
