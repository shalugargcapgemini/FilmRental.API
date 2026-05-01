namespace FilmRental.API.DTOs
{
    public class StaffCreateDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? PictureUrl { get; set; }
    }
}