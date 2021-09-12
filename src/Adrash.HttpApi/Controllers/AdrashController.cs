using Adrash.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Adrash.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AdrashController : AbpController
    {
        protected AdrashController()
        {
            LocalizationResource = typeof(AdrashResource);
        }
    }
}