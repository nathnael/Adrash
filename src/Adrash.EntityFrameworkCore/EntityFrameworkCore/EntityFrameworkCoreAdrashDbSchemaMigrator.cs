using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Adrash.Data;
using Volo.Abp.DependencyInjection;

namespace Adrash.EntityFrameworkCore
{
    public class EntityFrameworkCoreAdrashDbSchemaMigrator
        : IAdrashDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAdrashDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AdrashDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AdrashDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
