using CinemaHelper.Server.DTOs;

namespace CinemaHelper.Server.Mapper
{
    public static class CinemaMapper
    {
        public static CinemaHelper.Server.Entities.Cinema ToEntity(this AddCinemaDto game)
        {
            return new Entities.Cinema()
            {
                AuthorId = game.AuthorId,
                Title = game.Title,
                Description = game.Description,
            };
        }

        public static Entities.Cinema ToEntity(this UpdateCinemaDto game, int id)
        {
            return new Entities.Cinema()
            {
                AuthorId = game.AuthorId,
                Title = game.Title,
                Description = game.Description,
            };
        }

        public static CinemaDTO ToCinemaDTO(this Entities.Cinema game)
        {
            return new CinemaDTO(
                game.Id,
                game.Title,
                game.Description,
                game.AuthorId
            );
        }
    }
}
