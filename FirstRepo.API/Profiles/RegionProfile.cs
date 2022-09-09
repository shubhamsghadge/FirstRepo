using AutoMapper;

namespace FirstRepo.API.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.RegionResponse>().ReverseMap();

            // for different NAME Properties 
            // CreateMap<Models.Domain.Region, Models.DTO.RegionResponse>()
            //   .ForMember(dest => dest.id,opt => opt.MapFrom(src =>  src.Regionid));
        }
    }
}
