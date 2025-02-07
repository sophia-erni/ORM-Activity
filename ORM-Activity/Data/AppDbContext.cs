using Microsoft.EntityFrameworkCore;
using ORM_Activity.Models;

namespace ORM_Activity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<AuthorPublisher> AuthorsPublishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorPublisher>()
                .HasKey(ap => new { ap.AuthorId, ap.PublisherId });

            modelBuilder.Entity<AuthorPublisher>()
                .HasOne(ap => ap.Author)
                .WithMany(a => a.AuthorsPublishers)
                .HasForeignKey(ap => ap.AuthorId);

            modelBuilder.Entity<AuthorPublisher>()
                .HasOne(ap => ap.Publisher)
                .WithMany(p => p.AuthorsPublishers)
                .HasForeignKey(ap => ap.PublisherId);
        }

    }
}
