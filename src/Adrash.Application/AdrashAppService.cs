using System;
using System.Collections.Generic;
using System.Text;
using Adrash.Localization;
using Volo.Abp.Application.Services;

namespace Adrash
{
    /* Inherit your application services from this class.
     */
    public abstract class AdrashAppService : ApplicationService
    {
        protected AdrashAppService()
        {
            LocalizationResource = typeof(AdrashResource);
        }
    }
}
