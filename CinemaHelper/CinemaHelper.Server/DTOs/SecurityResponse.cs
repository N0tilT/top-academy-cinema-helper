using System.ComponentModel.DataAnnotations;

namespace CinemaHelper.Server.DTOs
{
    //Можно добавить доп. информацию о пользователе - ФИО, дата рождения и т.д.
    public record class SecurityResponse
        (
        int Id
        );

}
