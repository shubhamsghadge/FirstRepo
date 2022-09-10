using FirstRepo.API.Models.Domain;

namespace FirstRepo.API.Repository
{
    public interface IWalkDifficultyRepository
    {
        IEnumerable<WalkDifficulty> GetAll();
    }
}
