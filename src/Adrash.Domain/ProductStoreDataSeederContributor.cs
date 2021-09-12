using Adrash.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Adrash
{
    public class ProductStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductStoreDataSeederContributor(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Brand = "Nike",
                        Name = "Nike Men 2021",
                        Description = "Nike Men 2021",
                        ImageUrl = "image/nike_men_2021_shoes.jpg"
                    },
                    autoSave: true
                );

                await _productRepository.InsertAsync(
                    new Product
                    {
                        Brand = "Nike",
                        Name = "Nike Women 2021",
                        Description = "Nike Women 2021",
                        ImageUrl = "image/nike_women_2021_shoes.jpg"
                    },
                    autoSave: true
                );
            }
        }
    }
}
