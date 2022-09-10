using FirstRepo.API.Data;
using FirstRepo.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstRepo.API.Repository
{
    public class WalkDifficultyRepository : IWalkDifficultyRepository
    {
        private readonly FirstRepoDbContext firstRepoDbContext;

        public WalkDifficultyRepository(FirstRepoDbContext firstRepoDbContext)
        {
            this.firstRepoDbContext = firstRepoDbContext;
        }
        public IEnumerable<WalkDifficulty> GetAll()
        {
            return firstRepoDbContext.WalkDifficulty.ToList();
        }
    }
}
