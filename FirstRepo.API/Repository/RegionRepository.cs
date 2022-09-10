using FirstRepo.API.Data;
using FirstRepo.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstRepo.API.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly FirstRepoDbContext firstRepoDbContext;

        public RegionRepository(FirstRepoDbContext firstRepoDbContext)
        {
            this.firstRepoDbContext = firstRepoDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
          return await firstRepoDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetRegionByIDAsync(Guid id)
        {
          return await firstRepoDbContext.Regions.FirstOrDefaultAsync(x => x.id == id);
            
        }
    }
}
