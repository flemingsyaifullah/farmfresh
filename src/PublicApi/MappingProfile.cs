using AutoMapper;
using FarmFresh.ApplicationCore.Entities;
using FarmFresh.PublicApi.CatalogBrandEndpoints;
using FarmFresh.PublicApi.CatalogItemEndpoints;
using FarmFresh.PublicApi.CatalogTypeEndpoints;

namespace FarmFresh.PublicApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CatalogItem, CatalogItemDto>();
            CreateMap<CatalogType, CatalogTypeDto>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Type));
            CreateMap<CatalogBrand, CatalogBrandDto>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Brand));
        }
    }
}
