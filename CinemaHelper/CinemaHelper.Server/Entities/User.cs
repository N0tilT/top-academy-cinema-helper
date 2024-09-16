using Microsoft.AspNetCore.Identity;

namespace CinemaHelper.Server.Entities
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
