using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    public record class SecurityRequest
        ([Required] string Login,
        [Required] string Password);

}
