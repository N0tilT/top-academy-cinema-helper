using CinemaHelper.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaHelper.Server.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Entities.Cinema> Cinemas { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
