using Cz.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cz.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CzController : AbpControllerBase
{
    protected CzController()
    {
        LocalizationResource = typeof(CzResource);
    }
}
