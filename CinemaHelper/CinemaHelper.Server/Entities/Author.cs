using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CinemaHelper.Server.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Cinema>? Cinemas { get; set; }

        private const int MAX_NAME_LENGTH = 128;

        internal class Configuration() : IEntityTypeConfiguration<Author>
        {
            void IEntityTypeConfiguration<Author>.Configure(EntityTypeBuilder<Author> builder)
            {
                builder.Property(cinema => cinema.Id).IsRequired();

                builder.Property(cinema => cinema.Name)
                    .HasMaxLength(MAX_NAME_LENGTH)
                    .IsRequired();
            }
        }

    }
}
