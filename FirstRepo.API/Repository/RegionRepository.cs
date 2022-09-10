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

        public async Task<Region> AddRegionAsync(Region region)
        {
            region.id = Guid.NewGuid();
            await firstRepoDbContext.AddAsync(region);
            await firstRepoDbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region> DeleteRegionAsync(Guid id)
        {
            var region = await firstRepoDbContext.Regions.FirstOrDefaultAsync(x => x.id == id);
            if (region == null)
            {
                return null;
            }
            // Delete the region
            firstRepoDbContext.Regions.Remove(region);
           await firstRepoDbContext.SaveChangesAsync();
            return region;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
          return await firstRepoDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetRegionByIDAsync(Guid id)
        {
          return await firstRepoDbContext.Regions.FirstOrDefaultAsync(x => x.id == id);
            
        }

        public async Task<Region> UpdateRegionAsync(Guid id, Region region)
        {
           var existingRegion = await firstRepoDbContext.Regions.FirstOrDefaultAsync(x => x.id == id);

            if (existingRegion == null)
            {
                return null;
            }
            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.Area = region.Area;
            existingRegion.Lat = region.Lat;
            existingRegion.Long = region.Long;
            existingRegion.Population = region.Population;

           await firstRepoDbContext.SaveChangesAsync();
            return existingRegion;
        }
    }
}
