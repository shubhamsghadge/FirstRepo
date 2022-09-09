using FirstRepo.API.Models.Domain;

namespace FirstRepo.API.Repository
{
    public interface IRegionRepository
    {
       Task <IEnumerable<Region>> GetAllAsync();
    }
}
