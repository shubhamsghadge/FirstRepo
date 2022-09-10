using FirstRepo.API.Repository;
using Microsoft.AspNetCore.Mvc;
using FirstRepo.API.Models.Domain;
using FirstRepo.API.Models.DTO;

namespace FirstRepo.API.Controllers
{
    [ApiController]
    [Route("WalkDifficulty")]
    public class WalkDifficultyController : ControllerBase
    {
       
        private readonly IWalkDifficultyRepository walkDifficultyRepository;

        public WalkDifficultyController(IWalkDifficultyRepository walkDifficultyRepository)
        {
            this.walkDifficultyRepository = walkDifficultyRepository;
        }

        [HttpGet("FromDatabase")]
        //public async Task<IActionResult> GetRegions()
        //{
        //    var get = await regionRepository.GetAllAsync();
        //    return Ok(get);
        //}
        public IActionResult GetWalkDifficulty()
        {
            var get = walkDifficultyRepository.GetAll();
                return Ok(get);
        }
        [HttpGet]
        public IActionResult Get()
        {
            var any = new List<WalkDifficulty>()
            {
                new WalkDifficulty
                {
                    Id = Guid.NewGuid(),
                    Code = "nagpur"
                }
            };
            return Ok(any);
        }
    }
}
