using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    public record class UpdateAuthorDto(
        [Required][StringLength(128)] string Name
    );
}
