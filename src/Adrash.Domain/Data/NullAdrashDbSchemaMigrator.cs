using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Adrash.Data
{
    /* This is used if database provider does't define
     * IAdrashDbSchemaMigrator implementation.
     */
    public class NullAdrashDbSchemaMigrator : IAdrashDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}