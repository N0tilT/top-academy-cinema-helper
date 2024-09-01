using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaHelper.Server.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Author_id { get; set; }

        public Author? Author { get; set; }

        private const int MAX_TITLE_LENGTH = 64;
        private const int MAX_DESCRIPTION_LENGTH = 2048;

        internal class Configuration() : IEntityTypeConfiguration<Cinema>
        {
            void IEntityTypeConfiguration<Cinema>.Configure(EntityTypeBuilder<Cinema> builder)
            {
                builder.Property(cinema => cinema.Id).IsRequired();

                builder.Property(cinema => cinema.Title)
                    .HasMaxLength(MAX_TITLE_LENGTH)
                    .IsRequired();

                builder.Property(cinema => cinema.Description)
                    .HasMaxLength(MAX_DESCRIPTION_LENGTH)
                    .IsRequired();

                builder.HasOne(cinema => cinema.Author)
                    .WithMany(author => author.Cinemas)
                    .HasForeignKey(cinema => cinema.Author_id);
            }
        }


    }
}
