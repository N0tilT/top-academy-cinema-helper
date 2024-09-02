using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    public record class AddCinemaDto(
        [Required][StringLength(256)] string Title,
        [Required] int AuthorId,
        string Description
    );
}
