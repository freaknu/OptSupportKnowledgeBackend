using KnowledgeBaseAPI.Models;
using Microsoft.EntityFrameworkCore;
using optsupport.Model;

namespace KnowledgeBaseAPI.Data
{
    public class KnowledgeBaseContext : DbContext
    {
        public KnowledgeBaseContext(DbContextOptions<KnowledgeBaseContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<InventoryData> InventoryData { get; set; }
        public DbSet<ProcessStep> ProcessSteps { get; set; }
        public DbSet<Prerequisite> Prerequisites { get; set; }
        public DbSet<InventoryImage> InventoryImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryData>()
            .HasOne<Article>()
            .WithOne(a => a.InventoryData)
            .HasForeignKey<InventoryData>(id => id.ArticleId);
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasOne(a => a.Category)
                    .WithMany(c => c.Articles)
                    .HasForeignKey(a => a.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(a => a.InventoryData)
                    .WithOne(id => id.Article)
                    .HasForeignKey<InventoryData>(id => id.ArticleId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<InventoryData>(entity =>
            {
                entity.HasKey(id => id.Id);

                entity.HasMany(id => id.ProcessSteps)
                    .WithOne()
                    .HasForeignKey(ps => ps.InventoryDataId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(id => id.Prerequisites)
                    .WithOne()
                    .HasForeignKey(p => p.InventoryDataId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(id => id.Images)
                    .WithOne()
                    .HasForeignKey(i => i.InventoryDataId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.OwnsOne(id => id.ArticleLink, al =>
                {
                    al.Property(a => a.Url).HasColumnName("ArticleLink_Url");
                    al.Property(a => a.Text).HasColumnName("ArticleLink_Text");
                });

                entity.OwnsOne(id => id.Author, a =>
                {
                    a.Property(a => a.Name).HasColumnName("Author_Name");
                    a.Property(a => a.Avatar).HasColumnName("Author_Avatar");
                    a.Property(a => a.LastUpdated).HasColumnName("Author_LastUpdated");
                });

                entity.OwnsOne(id => id.AppLinks, al =>
                {
                    al.OwnsOne(a => a.PlayStore, ps =>
                    {
                        ps.Property(p => p.Url).HasColumnName("PlayStore_Url");
                        ps.Property(p => p.Image).HasColumnName("PlayStore_Image");
                    });

                    al.OwnsOne(a => a.AppStore, aps =>
                    {
                        aps.Property(a => a.Url).HasColumnName("AppStore_Url");
                        aps.Property(a => a.Image).HasColumnName("AppStore_Image");
                    });
                });
            });
        }
    }
}