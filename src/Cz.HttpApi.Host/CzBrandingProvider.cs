using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cz;

[Dependency(ReplaceServices = true)]
public class CzBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Cz";
}
