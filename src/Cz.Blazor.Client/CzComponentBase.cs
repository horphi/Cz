using Cz.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cz.Blazor.Client;

public abstract class CzComponentBase : AbpComponentBase
{
    protected CzComponentBase()
    {
        LocalizationResource = typeof(CzResource);
    }
}
