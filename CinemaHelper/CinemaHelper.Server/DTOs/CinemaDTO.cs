namespace CinemaHelper.Server.DTOs
{

    public record class CinemaDTO(
        int Id,
        string Title,
        string Description,
        int AuthorId);
}
