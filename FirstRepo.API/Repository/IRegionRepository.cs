using FirstRepo.API.Models.Domain;

namespace FirstRepo.API.Repository
{
    public interface IRegionRepository
    {
       Task <IEnumerable<Region>> GetAllAsync();
       Task<Region> GetRegionByIDAsync(Guid id);
       Task<Region> AddRegionAsync(Region region); 
       Task<Region> DeleteRegionAsync(Guid id);
       Task<Region> UpdateRegionAsync(Guid id , Region region);
        
    }
}
