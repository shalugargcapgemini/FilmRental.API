using Microsoft.EntityFrameworkCore;
using FilmRental.API.Models;

namespace FilmRental.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
    }
}