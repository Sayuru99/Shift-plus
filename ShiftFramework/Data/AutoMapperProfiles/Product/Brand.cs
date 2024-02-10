using AutoMapper;

namespace Data.AutoMapperProfiles.Product;

public class Brand : Profile
{
    public Brand()
    {
        CreateMap<Entities.Product.Brand, BrandDTO>().ReverseMap();
        CreateMap<Entities.Product.Brand, BrandListDTO>();
    }
}
