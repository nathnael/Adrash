using Volo.Abp.Modularity;

namespace Adrash
{
    [DependsOn(
        typeof(AdrashApplicationModule),
        typeof(AdrashDomainTestModule)
        )]
    public class AdrashApplicationTestModule : AbpModule
    {

    }
}