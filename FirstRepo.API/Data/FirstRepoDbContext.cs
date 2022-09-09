using FirstRepo.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstRepo.API.Data
{
    public class FirstRepoDbContext : DbContext
    {
        public FirstRepoDbContext(DbContextOptions<FirstRepoDbContext> options):base(options)
        {

        }
        // Create Regions Table for us  if it doesn't exist  in database
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
