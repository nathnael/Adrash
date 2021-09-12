using Adrash.Domain.Products;
using Adrash.Products;
using AutoMapper;

namespace Adrash
{
    public class AdrashApplicationAutoMapperProfile : Profile
    {
        public AdrashApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>();
        }
    }
}
