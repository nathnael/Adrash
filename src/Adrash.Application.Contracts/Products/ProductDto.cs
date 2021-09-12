using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Adrash.Products
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Brand { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
