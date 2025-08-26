using AutoMapper;
using Rira_Task.Models;

namespace Rira_Task.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Category,
                    opt => opt.MapFrom(src => src.Category.ToString()))
                .ReverseMap();
        }
    }
}
