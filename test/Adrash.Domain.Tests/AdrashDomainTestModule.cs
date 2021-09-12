using Adrash.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Adrash
{
    [DependsOn(
        typeof(AdrashEntityFrameworkCoreTestModule)
        )]
    public class AdrashDomainTestModule : AbpModule
    {

    }
}