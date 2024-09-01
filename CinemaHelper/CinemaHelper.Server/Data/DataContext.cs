using CinemaHelper.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaHelper.Server.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Cinema.Configuration());
            modelBuilder.ApplyConfiguration(new Author.Configuration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
