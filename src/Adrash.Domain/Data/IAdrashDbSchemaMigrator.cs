using System.Threading.Tasks;

namespace Adrash.Data
{
    public interface IAdrashDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
