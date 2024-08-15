using System;
using System.Collections.Generic;
using System.Text;
using Cz.Localization;
using Volo.Abp.Application.Services;

namespace Cz;

/* Inherit your application services from this class.
 */
public abstract class CzAppService : ApplicationService
{
    protected CzAppService()
    {
        LocalizationResource = typeof(CzResource);
    }
}
