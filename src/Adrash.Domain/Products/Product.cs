using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Adrash.Domain.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Brand { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}