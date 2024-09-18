using CinemaHelper.Server.DTOs;
using CinemaHelper.Server.Entities;
using CinemaHelper.Server.Utilities;

namespace CinemaHelper.Server.Mapper
{
    public static class SecurityMapper
    {
        public static User ToEntity(this SecurityRequest request)
        {
            return new User()
            {
                Login = request.Login,
                Password = Encoder.ComputeSHA256Hash(request.Password),
            };
        }

        public static SecurityResponse ToResponse(this User user)
        {
            return new SecurityResponse(
                user.Id
            );
        }
    }
}
