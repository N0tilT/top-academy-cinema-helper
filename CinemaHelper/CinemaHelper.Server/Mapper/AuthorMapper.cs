using CinemaHelper.Server.DTOs;

namespace CinemaHelper.Server.Mapper
{
    public static class AuthorMapper
    {
        public static CinemaHelper.Server.Entities.Author ToEntity(this AddAuthorDto game)
        {
            return new Entities.Author()
            {
                Name = game.Name,
            };
        }

        public static Entities.Author ToEntity(this UpdateAuthorDto game, int id)
        {
            return new Entities.Author()
            {
                Name = game.Name,
            };
        }

        public static AuthorDTO ToAuthorDTO(this Entities.Author game)
        {
            return new AuthorDTO(
                game.Id,
                game.Name
            );
        }
    }
}
