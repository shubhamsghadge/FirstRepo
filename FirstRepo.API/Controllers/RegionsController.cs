using AutoMapper;
using FirstRepo.API.Models.Domain;
using FirstRepo.API.Models.DTO;
using FirstRepo.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstRepo.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private IRegionRepository regionRepository;
        private IMapper mapper;
       

        public RegionsController(IRegionRepository regionRepository, IMapper mapper )
        {
            this.regionRepository= regionRepository;
            this.mapper = mapper;
            
        }

        public IRegionRepository RegionRepository { get; }

        [HttpGet("Static")]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    id = Guid.NewGuid(),
                    Name = "Mumbai",
                    Code = "Mum",
                    Area = 456123,
                    Lat = -1.2589,
                    Long = 359.456,
                    Population = 10456789
                },
                new Region
                {
                    id = Guid.NewGuid(),
                    Name = "Pune",
                    Code = "Pun",
                    Area = 356123,
                    Lat = -2.2589,
                    Long = 459.456,
                    Population = 7456789
                }
            };
            return Ok(regions);
        }

        [HttpGet("FromDatabase")]
        public async Task<IActionResult> GetRegions()
        {
           var get = await regionRepository.GetAllAsync();
            return Ok(get);
        }

        [HttpGet]
     
        public async Task<IActionResult> GetRegionsFromDTO()
        {
            var get = await regionRepository.GetAllAsync();

            // return DTO regions
            var regionDTO = new List<Models.DTO.RegionResponse>();
            get.ToList().ForEach(domainregion =>
            {
                var aDTO = new RegionResponse()
                {
                    id = domainregion.id,
                    Code = domainregion.Code,
                    Name = domainregion.Name,
                    Area = domainregion.Area,
                    Lat = domainregion.Lat,
                    Long = domainregion.Long,
                    Population = domainregion.Population,
                };
                regionDTO.Add(aDTO);
            });
            return Ok(regionDTO);
        }

        [HttpGet("UsingAutoMapper")]
        public async Task<IActionResult> GetRegionsUsingAutoMapper()
        {
            var get = await regionRepository.GetAllAsync();
            var regionmap = mapper.Map<List<Models.DTO.RegionResponse>>(get);
            return Ok(regionmap);
        }
      
    }
}
