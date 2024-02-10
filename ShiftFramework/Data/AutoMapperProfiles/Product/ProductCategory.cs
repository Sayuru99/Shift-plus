using AutoMapper;

namespace Data.AutoMapperProfiles.Product;

public class ProductCategory : Profile
{
    public ProductCategory()
    {
        CreateMap<Entities.Product.ProductCategory, ProductCategoryDTO>().ReverseMap();

        CreateMap<Entities.Product.ProductCategory, ProductCategoryListDTO>();
    }
}

