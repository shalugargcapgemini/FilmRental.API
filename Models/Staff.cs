using System.ComponentModel.DataAnnotations;

namespace FilmRental.API.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress]
        public string? Email { get; set; }

        // Picture stored as URL
        public string? PictureUrl { get; set; }
    }
}