using EcomService.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EcomService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

    }
}
