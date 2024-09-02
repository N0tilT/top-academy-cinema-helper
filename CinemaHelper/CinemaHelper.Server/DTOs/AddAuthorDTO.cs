using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    public record class AddAuthorDto(
        [Required][StringLength(128)] string Name
    );
}
