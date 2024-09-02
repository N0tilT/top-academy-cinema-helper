using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    public class CreateGameDto(
        [Required][StringLength(50)] string Name,
        int GenreId,
        [Range(1, 100)] decimal Price,
        DateOnly ReleaseDate
    );
}
