using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Adrash
{
    [Dependency(ReplaceServices = true)]
    public class AdrashBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Adrash";
    }
}
